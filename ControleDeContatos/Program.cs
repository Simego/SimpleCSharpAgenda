using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ControleDeContatos
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Connection.Open();
            Application.Run(new TelaPrincipal());
            Connection.Close();
        }
    }
}
