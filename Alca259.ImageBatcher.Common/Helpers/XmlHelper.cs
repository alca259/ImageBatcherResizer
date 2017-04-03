using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using Alca259.ImageBatcher.Common.Attributes;

namespace Alca259.ImageBatcher.Common.Helpers
{
    public class XmlHelper<T> where T : class
    {
        public static bool SaveToDisk(IEnumerable<T> objs, string fullPathName, bool removeFileFirst = false)
        {
            if (removeFileFirst && System.IO.File.Exists(fullPathName))
            {
                System.IO.File.Delete(fullPathName);
            }

            foreach (var obj in objs)
            {
                if (!SaveToDisk(obj, fullPathName)) return false;
            }

            return true;
        }

        public static bool SaveToDisk(T obj, string fullPathName, bool removeFileFirst = false)
        {
            var props = obj.GetType().GetProperties().Where(w => w.GetCustomAttribute(typeof(SerializableFieldAttribute)) != null).ToList();

            if (!props.Any())
            {
                Debug.WriteLine($"ERROR: No properties defined for {obj.GetType().Name}");
                return false;
            }

            var linea = new XElement("LINE");
            foreach (var propertyInfo in props)
            {
                linea.Add(new XAttribute(propertyInfo.Name, propertyInfo.GetValue(obj).ToString()));
            }

            if (removeFileFirst && System.IO.File.Exists(fullPathName))
            {
                System.IO.File.Delete(fullPathName);
            }

            if (!System.IO.File.Exists(fullPathName))
            {
                var dataXml = new XElement("DATA", linea);
                dataXml.Save(fullPathName);
            }
            else
            {
                var doc = XDocument.Load(fullPathName, LoadOptions.SetLineInfo);
                doc.Root?.Add(linea);
                doc.Save(fullPathName);
            }

            return true;
        }

        public static List<T> ReadFromDisk(string fullPathName)
        {
            var lista = new List<T>();

            if (!System.IO.File.Exists(fullPathName)) return lista;
            var doc = XDocument.Load(fullPathName, LoadOptions.SetLineInfo);

            if (doc.Root == null) return lista;
            var elementos = doc.Root.Descendants().ToList();
            var props = typeof(T).GetProperties().Where(w => w.GetCustomAttribute(typeof(SerializableFieldAttribute)) != null).ToList();

            if (!props.Any()) return lista;

            foreach (var elem in elementos)
            {
                var obj = (T)Activator.CreateInstance(typeof(T));

                foreach (var propertyInfo in props)
                {
                    var value = elem.Attribute(propertyInfo.Name)?.Value;
                    SetPropertyValueFromString(obj, propertyInfo.Name, value);
                }

                lista.Add(obj);
            }

            return lista;
        }

        private static void SetPropertyValueFromString(object target, string propertyName, string propertyValue)
        {
            var oProp = target.GetType().GetProperty(propertyName);
            var tProp = oProp.PropertyType;

            // Si la propiedad es del tipo nullable, necesita un tratamiento previo para obtener el tipo original
            if (tProp.IsGenericType && tProp.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                // Si es nulo, le ponemos que es null y devolvemos
                if (propertyValue == null)
                {
                    oProp.SetValue(target, null, null);
                    return;
                }

                // La obtenemos
                tProp = new NullableConverter(oProp.PropertyType).UnderlyingType;
            }

            // Usamos el conversor para obtener el tipo correcto en el valor
            oProp.SetValue(target, Convert.ChangeType(propertyValue, tProp), null);
        }
    }
}
