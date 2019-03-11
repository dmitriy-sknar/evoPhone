using EvoPhone.Common;

namespace evoPhone.biz {
    public class Speaker : IPhonePart {
        /// <summary>
        /// Phone Dynamic. Can be mono or stereo.
        /// </summary>
        /// <param name="maxVol"></param>
        /// <param name="isStereo"></param>
        public Speaker(int maxVol, bool isStereo) {
            MaxVol = maxVol;
            IsStereo = isStereo;
        }

        public int MaxVol { get; private set; }

        public bool IsStereo { get; private set; }

        public override string ToString() {
            return "Speaker";
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