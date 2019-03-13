using System;
using System.Linq;
using System.Text;
using evoPhone.biz.PhoneParts.Battery.Charger;
using evoPhone.biz.PhoneParts.Sound;
using evoPhone.biz.PhoneParts.Sound.Headset;
using EvoPhone.Common;

namespace evoPhone.biz {
    class Program {
        private static IPlayback vPlaybackComponent;
        private static string vSound = "";
        private static ICharger vChargerComponent;
        private static IOutput vOutputComponent = new ConsoleOutput();

        static void Main(string[] args) {
            PhoneBuilder builder = new SimCorpPhoneBuilder();
            PhoneConstructor phoneConstructor = new PhoneConstructor(builder);
            phoneConstructor.Construct();
            var mobile = builder.GetMobile;
            mobile.SetAllActive();
            Console.WriteLine(mobile);

            GetPlaybackConfiguration();
            vPlaybackComponent.IsConnected = true;
            mobile.PlaybackComponent = vPlaybackComponent;
            mobile.Play(vSound);

            GetChargeConfiguration();
            vChargerComponent.IsReachableConnected = true;
            mobile.ChargerComponent = vChargerComponent;
            mobile.Charge("Green power");

            Console.ReadKey();
        }

        static void GetPlaybackConfiguration() {
            var valid = false;
            int selection = 0;
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine();
            stringBuilder.Append("Select headset: ");
            stringBuilder.Append("\n1 - " + nameof(MaxStereoHeadset));
            stringBuilder.Append("\n2 - " + nameof(BluetoothHeadset));
            stringBuilder.Append("\n3 - " + nameof(StereoHeadset));
            stringBuilder.Append("\n4 - " + nameof(Speaker));
            stringBuilder.Append("\nEnter your choice: \n");
            Console.Write(stringBuilder);

            while (!valid) {
                var val = Console.ReadLine();

                valid = !string.IsNullOrWhiteSpace(val) &&
                        val.All(c => c > '0' && c <= '4') &&
                        val.Length == 1;

                if (!valid) Console.WriteLine("Please input valid number:");
                else int.TryParse(val, out selection);
            }
            Console.WriteLine("Success!\n");

            switch (selection) {
                case 1:
                    vPlaybackComponent = new MaxStereoHeadset(true, vOutputComponent);
                    vSound = "Perfect MaxStereo vSound";
                    break;
                case 2:
                    vPlaybackComponent = new BluetoothHeadset("Bluetooth 4.2", vOutputComponent);
                    vSound = "Perfect Bluetooth vSound";
                    break;
                case 3:
                    vPlaybackComponent = new StereoHeadset(true, vOutputComponent);
                    vSound = "So-so Stereo vSound";
                    break;
                case 4:
                    vPlaybackComponent = new Speaker(100, false, vOutputComponent);
                    vSound = "Horrible Speaker vSound";
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        static void GetChargeConfiguration() {
            var valid = false;
            int selection = 0;
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine();
            stringBuilder.Append("Select charger: ");
            stringBuilder.Append("\n1 - " + nameof(StandardCharger));
            stringBuilder.Append("\n2 - " + nameof(WirelessCharger));
            stringBuilder.Append("\nEnter your choice: \n");
            Console.Write(stringBuilder);

            while (!valid) {
                var val = Console.ReadLine();

                valid = !string.IsNullOrWhiteSpace(val) &&
                        val.All(c => c > '0' && c <= '2') &&
                        val.Length == 1;

                if (!valid)
                    Console.WriteLine("Please input valid number:");
                else
                    int.TryParse(val, out selection);
            }
            Console.WriteLine("Success!\n");

            switch (selection) {
                case 1:
                vChargerComponent = new StandardCharger(vOutputComponent);
                break;
                case 2:
                vChargerComponent = new WirelessCharger(vOutputComponent);
                break;
                default:
                throw new ArgumentException();
            }
        }
    }
}