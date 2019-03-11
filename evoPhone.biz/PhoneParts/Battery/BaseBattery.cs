using EvoPhone.Common;

namespace evoPhone.biz {
    public abstract class BaseBattery : Battery, IPhonePart {
        public BaseBattery() {
            Capacity = 800;
            Size = new int[] {80, 40, 5};
        }

        public BaseBattery(int volume, int height, int width, int length) {
            Capacity = volume;
            Size = new int[] {height, width, length};
        }

        public int Capacity {
            get { return vCapacity; }
            private set { vCapacity = value; }
        }
        
        public int[] Size {
            get { return vSize; }
            private set { vSize = value; }
        }

        public abstract override void Charge();

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