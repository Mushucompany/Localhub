using System;
using System.Windows.Forms;

namespace LocalHubHubApp
{
    static class Program
    {
        public const string EditionTitle = "LocalHub — Multi-Language Hub";
        public const string EditionEmail = "hub@localhub.dev";

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}