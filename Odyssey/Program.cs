using System;
using System.Windows.Forms;
using Odyssey.UI;

namespace Odyssey
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new FormStart().Show();
            Application.Run();
        }
    }
}