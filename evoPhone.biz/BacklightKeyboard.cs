using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoPhone.biz {

    public class BacklightKeyboard : BaseKeyboard {
        /// <summary>
        /// English keyboard with backlight off.
        /// </summary>
        public BacklightKeyboard() : base()
        {
            this.IsBacklightOn = false;
        }

        /// <summary>
        /// Keyboard with backlight
        /// </summary>
        /// <param name="isBacklightOn"></param>
        /// <param name="figures"></param>
        /// <param name="letters"></param>
        public BacklightKeyboard(bool isBacklightOn, int[] figures, char[] letters) : base(figures, letters) {
            this.IsBacklightOn = isBacklightOn;
        }

        private bool isBacklightOn;

        public bool IsBacklightOn
        {
            get { return isBacklightOn; }
            set { isBacklightOn = value; }
        }

        public override string ToString() {
            return "Keyboard with backlight";
        }
    }
}
