using OCESACNA.Engine;
using OCESACNA.View.Menu;
using System;
using System.Windows.Forms;

namespace OCESACNA
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Controller.Initialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new AuthMenu());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
