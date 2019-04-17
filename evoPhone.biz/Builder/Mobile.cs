using System.Collections.Generic;
using System.Text;
using evoPhone.biz.PhoneParts.Battery.Charger;
using evoPhone.biz.PhoneParts.SMS;
using evoPhone.biz.PhoneParts.Sound;
using EvoPhone.Common;

namespace evoPhone.biz {
    public class Mobile {
        public string PhoneModel { get; }
        private readonly Dictionary<string, IPhonePart> vParts = new Dictionary<string, IPhonePart>();
        public IPlayback PlaybackComponent { get; set; }
        public ICharger ChargerComponent { get; set; }
        public SMSStorage SmsStorage { get; set; }
        public CallStorage CallStorage { get; set; }
        public Battery Battery { get; set; }

        public Mobile(string phoneModel) {
            PhoneModel = phoneModel;
            // init always present components
            InitBasicComponents();
        }

        private void InitBasicComponents() {
            SmsStorage = new SMSStorage();
            CallStorage = new CallStorage();
        }

        public IPhonePart this[string key] {
            get { return vParts[key]; }
            set { vParts[key] = value; }
        }

        public override string ToString() {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine();
            stringBuilder.Append('-', 80);
            stringBuilder.AppendLine();
            stringBuilder.Append($"Phone Model: {PhoneModel}");
            stringBuilder.AppendLine();

            foreach (KeyValuePair<string, IPhonePart> pair in vParts) {
                string status;
                switch (vParts[pair.Key].GetStatus()) {
                    case PartStatus.Activated:
                        status = "Active";
                        break;
                    case PartStatus.Deactivated:
                        status = "Deactivated";
                        break;
                    default:
                        status = "Not Applicable";
                        break;
                }

                stringBuilder.Append($" {pair.Key.FirstCharToUpper()} : {vParts[pair.Key].ToString()}."
                                     + " Part status: " + status);
                stringBuilder.AppendLine();
            }

            stringBuilder.Append('-', 80);
            return stringBuilder.ToString();
        }

        public void SetAllActive() {
            var phoneParts = vParts.Values;
            foreach (IPhonePart phonePart in phoneParts) {
                phonePart.SetActive();
            }
        }

        public void SetScreenOff() {
            foreach (var keyValPair in vParts) {
                if (keyValPair.Key == "screen") {
                    keyValPair.Value.SetDeactivated();
                }
            }
        }

        public void Play(object soundData) {
            PlaybackComponent.Play(soundData);
        }

        public void Charge(object energy) {
            ChargerComponent.Charge(energy);
        }
    }
}