using System;
using System.Linq;
using System.Windows.Forms;
using evoPhone.biz;
using evoPhone.biz.PhoneParts.Battery.Charger;
using evoPhone.biz.PhoneParts.Sound;
using evoPhone.biz.PhoneParts.Sound.Headset;
using EvoPhone.Common;
using Playback.Output;

namespace evoPhone.GUI {
    public partial class PlaybackSelectOptForm : Form {
        private IPlayback vPlaybackComponent;
        private ICharger vChargerComponent;
        private IOutput vOutputComponent;
        private Mobile vMobile;

        public PlaybackSelectOptForm() {
            InitializeComponent();

            PhoneBuilder builder = new SimCorpPhoneBuilder();
            var phoneConstructor = new PhoneConstructor(builder);
            phoneConstructor.Construct();
            vMobile = builder.GetMobile;
            vMobile.SetAllActive();
            vOutputComponent = new WinFormOutput(this.LogTextBox);
        }

        private void PlayButton_Click(object sender, EventArgs e) {
            var radioButtons = PlayOptionsGroup.Controls.OfType<RadioButton>();
            string rbName = "";
            string sound = "";
            foreach (RadioButton rb in radioButtons) {
                if (rb.Checked) rbName = rb.Name;
            }

            if (rbName.Equals("")) return;

            switch (rbName) {
                case nameof(MaxStereoHeadset):
                    vPlaybackComponent = new MaxStereoHeadset(true, vOutputComponent);
                    sound = "Perfect MaxStereo sound";
                    break;
                case nameof(BluetoothHeadset):
                    vPlaybackComponent = new BluetoothHeadset("Bluetooth 4.2", vOutputComponent);
                    sound = "Perfect Bluetooth sound";
                    break;
                case nameof(StereoHeadset):
                    vPlaybackComponent = new StereoHeadset(true, vOutputComponent);
                    sound = "So-so Stereo sound";
                    break;
                case nameof(Speaker):
                    vPlaybackComponent = new Speaker(100, false, vOutputComponent);
                    sound = "Horrible Speaker sound";
                    break;
                default:
                    throw new ArgumentException();
            }
            vPlaybackComponent.IsConnected = true;
            vMobile.PlaybackComponent = vPlaybackComponent;
            vMobile.Play(sound);
            vOutputComponent.WriteLine(rbName + " playback selected.\n");
        }


        private void ChargeButton_Click(object sender, EventArgs e) {
            var radioButtons = ChargeOptionsGroup.Controls.OfType<RadioButton>();
            string rbName = "";
            foreach (RadioButton rb in radioButtons) {
                if (rb.Checked)
                    rbName = rb.Name;
            }

            if (rbName.Equals("")) return;

            switch (rbName) {
                case nameof(StandardCharger):
                    vChargerComponent = new StandardCharger(vOutputComponent);
                    break;
                case nameof(WirelessCharger):
                    vChargerComponent = new WirelessCharger(vOutputComponent);
                    break;
                default:
                    throw new ArgumentException();
            }
            vChargerComponent.IsReachableConnected = true;
            vMobile.ChargerComponent = vChargerComponent;
            vMobile.Charge("Green power");
            vOutputComponent.WriteLine(rbName + " charger selected.\n");
        }
    }
}