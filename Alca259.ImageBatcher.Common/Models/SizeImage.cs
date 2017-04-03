using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Alca259.ImageBatcher.Common.Attributes;

namespace Alca259.ImageBatcher.Common.Models
{
    public class SizeImage : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _widthSize;
        private int _heightSize;
        private string _category;

        public SizeImage()
        {
            
        }

        public SizeImage(int w, int h)
        {
            WidthSize = w;
            HeightSize = h;
        }

        public SizeImage(int w, int h, string c)
        {
            WidthSize = w;
            HeightSize = h;
            Category = c;
        }

        [SerializableField]
        public int WidthSize
        {
            get
            {
                return _widthSize;
            }
            set
            {
                _widthSize = value;
                OnPropertyChanged();
            }
        }

        [SerializableField]
        public int HeightSize
        {
            get
            {
                return _heightSize;
            }
            set
            {
                _heightSize = value;
                OnPropertyChanged();
            }
        }

        [SerializableField]
        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
                OnPropertyChanged();
            }
        }

        public string Label => $"[{Category}] {WidthSize}x{HeightSize}";

        protected void OnPropertyChanged([CallerMemberName] string PropertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}