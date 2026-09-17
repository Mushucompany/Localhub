using System;
using System.Windows.Forms;

namespace LocalHubApp
{
    static class Program
    {
        // Издание определяется при сборке через DefineConstants
#if EDITION_CPP
        public const string EditionKey = "cpp";
        public const string EditionTitle = "LocalHub — C++ Edition";
#elif EDITION_CS
        public const string EditionKey = "cs";
        public const string EditionTitle = "LocalHub — C# Edition";
#elif EDITION_C
        public const string EditionKey = "c";
        public const string EditionTitle = "LocalHub — C Edition";
#elif EDITION_JAVA
        public const string EditionKey = "java";
        public const string EditionTitle = "LocalHub — Java Edition";
#else
        public const string EditionKey = "hub";
        public const string EditionTitle = "LocalHub — Multi-Language Hub";
#endif

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
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