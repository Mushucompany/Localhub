using System;
using System.Windows.Forms;

namespace LocalHubJavaApp
{
    static class Program
    {
        public const string EditionTitle = "LocalHub — Java Edition";
        public const string EditionEmail = "java-edition@localhub.dev";

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