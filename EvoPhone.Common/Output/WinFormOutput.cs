using System.Windows.Forms;
using EvoPhone.Common;

namespace Playback.Output {
    public class WinFormOutput : IOutput {
        private RichTextBox vTextBox;
        public WinFormOutput(RichTextBox textBox) {
            vTextBox = textBox;
        }
        public void Write(string text) {
            vTextBox.AppendText(text);
            vTextBox.ScrollToCaret();
        }

        public void WriteLine(string text) {
            vTextBox.AppendText(text + '\n');
            vTextBox.ScrollToCaret();
        }
    }
}
