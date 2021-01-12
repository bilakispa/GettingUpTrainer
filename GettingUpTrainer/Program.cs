using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace GettingUpTrainer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new UserInterfaceForm());
        }
    }
}
