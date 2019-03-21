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

            //Lab2 form
            //var form = new PlaybackSelectOptForm(); 
            
            //Lab3 form
            var form = new MessageFormattingForm(); 
            Application.Run(form);
        }
    }
}