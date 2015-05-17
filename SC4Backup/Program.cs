using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SC4Backup
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

            if (Properties.Settings.Default.FirstRun == true)
            {
                Application.Run(new SettingsForm());
            }

            Application.Run(new MainForm());
        }
    }
}
