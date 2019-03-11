using EvoPhone.Common;

namespace evoPhone.biz {
    public class Microphone : IPhonePart {
        /// <summary>
        /// Phone microphone.
        /// </summary>
        /// <param name="sensivity"></param>
        /// <param name="isMuted"></param>
        public Microphone(int sensivity, bool isMuted) {
            this.Sensivity = sensivity;
            this.IsMuted = isMuted;
        }

        public int Sensivity { get; set; }

        public bool IsMuted { get; set; }

        public override string ToString() {
            return "Microphone";
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