using EvoPhone.Common;

namespace evoPhone.biz {
    public abstract class Screen : IScreen, IPhonePart {
        public abstract void Show(IScreenImage screenImage);
        public abstract void Show(IScreenImage screenImage, int brightness);
        public abstract double ImageSize { get; protected set; }
        public abstract int ColorDepth { get; protected set; }
        public abstract int PixelsX { get; protected set; }
        public abstract int PixelsY { get; protected set; }

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