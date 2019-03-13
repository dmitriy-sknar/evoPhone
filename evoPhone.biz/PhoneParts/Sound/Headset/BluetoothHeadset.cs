using evoPhone.biz.PhoneParts.Connectivity;
using EvoPhone.Common;

namespace evoPhone.biz.PhoneParts.Sound.Headset {
    public class BluetoothHeadset : IPlayback, IBlueTooth {
        private IOutput vOutput;
        private string vVersion;

        public BluetoothHeadset(string version, IOutput output) {
            vOutput = output;
            vVersion = version;
        }

        public void Play(object soundData) {
            if (IsConnected) vOutput.WriteLine(this + $" Sound is like this: \n {soundData}");
            else vOutput.WriteLine(this + " Bluetooth is not connected. Check connection");
        }

        public string Version {
            get { return vVersion; }
        }

        public bool IsConnected { get; set; }

        public override string ToString() {
            return $"{nameof(BluetoothHeadset)} playback. \n Bluetooth version is: {Version}\n";
        }
    }
}