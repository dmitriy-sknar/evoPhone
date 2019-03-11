using EvoPhone.Common;

namespace evoPhone.biz {
    public class BaseKeyboard : IPhonePart {
        /// <summary>
        /// Basic keyboard with English alphabet
        /// </summary>
        public BaseKeyboard() {
            this.Figures = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
            this.Letters = new char[] {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u',
                'v', 'w', 'x', 'y', 'z',
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'G', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U',
                'V', 'W', 'X', 'Y', 'Z',
                ' ', '_', '!', '?', '@', '%', '$', '#', '(', ')'
            };
        }

        /// <summary>
        /// Basic keyboard 
        /// </summary>
        /// <param name="figures"></param>
        /// <param name="letters"></param>
        public BaseKeyboard(int[] figures, char[] letters) {
            Figures = figures;
            Letters = letters;
        }

        public int[] Figures { get; private set; }

        public char[] Letters { get; private set; }

        public override string ToString() {
            return "Base Keyboard";
        }

        private PartStatus vPartStatus;

        public PartStatus GetStatus() {
            return vPartStatus;
        }

        public void SetActive() {
            vPartStatus = PartStatus.Activated;
        }

        public void SetDeactivated() {
            vPartStatus = PartStatus.Deactivated;
        }
    }
}