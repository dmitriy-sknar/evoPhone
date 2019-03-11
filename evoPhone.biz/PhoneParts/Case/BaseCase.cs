using EvoPhone.Common;

namespace evoPhone.biz {
    public class BaseCase : IPhonePart {
        /// <summary>
        /// Phone case
        /// </summary>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="length"></param>
        public BaseCase(int height, int width, int length) {
            Height = height;
            Width = width;
            Length = length;
        }

        public int Height { get; private set; }

        public int Width { get; private set; }

        public int Length { get; private set; }

        private PartStatus vPartStatus;

        public PartStatus GetStatus() {
            return PartStatus.NotApplicable;
        }

        public void SetActive() {
            vPartStatus = PartStatus.NotApplicable;
        }

        public void SetDeactivated() {
            vPartStatus = PartStatus.NotApplicable;
        }
    }
}