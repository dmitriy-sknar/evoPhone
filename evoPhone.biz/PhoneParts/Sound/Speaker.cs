using System;
using evoPhone.biz.PhoneParts.Sound;
using EvoPhone.Common;

namespace evoPhone.biz {
    public class Speaker : IPlayback, IPhonePart {
        /// <summary>
        /// Phone Dynamic. Can be mono or stereo.
        /// </summary>
        /// <param name="maxVol"></param>
        /// <param name="isStereo"></param>
        public Speaker(int maxVol, bool isStereo) {
            MaxVol = maxVol;
            IsStereo = isStereo;
            IsConnected = true;
        }
        public Speaker(int maxVol, bool isStereo, IOutput output) : this(maxVol, isStereo) {
            vOutput = output;
        }

        protected IOutput vOutput;
        public int MaxVol { get; private set; }

        public bool IsStereo { get; private set; }

        public bool IsConnected { get; set; }

        public override string ToString() {
            return "Speaker";
        }

        public void Play(object soundData) {
            vOutput.WriteLine(this + $" Sound is like this: \n {soundData}");
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