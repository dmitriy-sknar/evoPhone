namespace evoPhone.biz {
    public class BacklightKeyboard : BaseKeyboard {
        /// <summary>
        /// English keyboard with backlight off.
        /// </summary>
        public BacklightKeyboard() {
            IsBacklightOn = false;
        }

        /// <summary>
        /// Keyboard with backlight
        /// </summary>
        /// <param name="isBacklightOn"></param>
        /// <param name="figures"></param>
        /// <param name="letters"></param>
        public BacklightKeyboard(bool isBacklightOn, int[] figures, char[] letters) : base(figures, letters) {
            IsBacklightOn = isBacklightOn;
        }

        public bool IsBacklightOn { get; set; }

        public override string ToString() {
            return $"Keyboard with backlight. Backlight is: {(IsBacklightOn ? "On" : "Off")}";
        }
    }
}