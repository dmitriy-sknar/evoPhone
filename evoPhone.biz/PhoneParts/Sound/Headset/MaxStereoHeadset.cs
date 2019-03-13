using EvoPhone.Common;

namespace evoPhone.biz.PhoneParts.Sound.Headset {
    public class MaxStereoHeadset : StereoHeadset {

        public MaxStereoHeadset(bool micPresent, IOutput output) : base(micPresent, output) {}

        public override void Play(object soundData) {
            if (IsConnected && !IsButtonPressed)
                vOutput.WriteLine(this + $"This is stereo sound. So you can 'hear' two sounds: \n {soundData} \n {soundData.ToString().ToUpper()}");
            else if (IsConnected && IsButtonPressed) {
                vOutput.WriteLine(this + " Headset button is pressed. Playback is on pause");
            } else {
                vOutput.WriteLine(this + " Headset is not connected.");
            }
        }
        
        public override string ToString() {
            return $"{nameof(MaxStereoHeadset)} playback. Microphone is: {(IsMicrophonePresent ? "Present" : "Not present")}.\n";
        }
    }
}
