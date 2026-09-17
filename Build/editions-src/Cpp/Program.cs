using System;
using System.Windows.Forms;

namespace LocalHubCppApp
{
    static class Program
    {
        public const string EditionTitle = "LocalHub — C++ Edition";
        public const string EditionEmail = "cpp-edition@localhub.dev";

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