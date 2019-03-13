using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvoPhone.Common;

namespace evoPhone.biz.PhoneParts.Sound.Headset {
    public class StereoHeadset : IPlayback, IMiniJack {
        protected IOutput vOutput;

        public StereoHeadset(bool micPresent, IOutput output) {
            IsMicrophonePresent = micPresent;
            vOutput = output;
            IsButtonPressed = false;
        }

        public virtual void Play(object soundData) {
            if (IsConnected && !IsButtonPressed)
                vOutput.WriteLine(this + $" Sound is like this: \n {soundData}");
            else if (IsConnected && IsButtonPressed) {
                vOutput.WriteLine(this + " Headset button is pressed. Playback is on pause");
            }
            else {
                vOutput.WriteLine(this + " Headset is not connected.");
            }
        }

        public bool IsConnected { get; set; }

        public bool IsMicrophonePresent { get; }

        public bool IsButtonPressed { get; set; }

        public override string ToString() {
            return $"{nameof(StereoHeadset)} playback. Microphone is: {(IsMicrophonePresent ? "Present" : "Not present")}.\n";
        }
    }
}