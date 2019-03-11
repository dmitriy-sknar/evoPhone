using EvoPhone.Common;

namespace evoPhone.biz {
    /// <summary>
    /// Touch with coordinates
    /// </summary>
    public class BaseTouch : ITouch, IPhonePart {
        public BaseTouch(int touchPosX, int touchPosY) {
            TouchPosX = touchPosX;
            TouchPosY = touchPosY;
        }

        public int TouchPosX { get; set; }

        public int TouchPosY { get; set; }

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