using System;
using System.Windows.Forms;
using Alca259.ImageBatcher.UI.UIForms;

namespace Alca259.ImageBatcher.UI
{
    static class AppStart
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
