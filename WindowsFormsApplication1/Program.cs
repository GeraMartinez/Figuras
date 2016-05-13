using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //creamos las ordenes
            Form2 sp = new Form2();
            //cuando el temporalizador lance el Dialogo de resultados se ejecuta la forma 1
            if (sp.ShowDialog()== DialogResult.OK)
            {

            }
            Application.Run(new Form1());
        }
    }
}
