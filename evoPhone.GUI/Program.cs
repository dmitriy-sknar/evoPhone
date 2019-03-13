using System;
using System.Windows.Forms;

namespace evoPhone.GUI {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new PlaybackSelectOptForm();
            Application.Run(form);
        }
    }
}