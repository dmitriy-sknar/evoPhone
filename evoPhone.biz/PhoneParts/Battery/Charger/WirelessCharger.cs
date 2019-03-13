using EvoPhone.Common;

namespace evoPhone.biz.PhoneParts.Battery.Charger {
    public class WirelessCharger : ICharger {
        private IOutput vOutput;

        public WirelessCharger(IOutput output) {
            vOutput = output;
        }

        public bool IsReachableConnected { get; set; }

        public void Charge(object energy) {
            if (IsReachableConnected)
                vOutput.WriteLine($"{nameof(WirelessCharger)} charger.\nCharging the battery by air with {energy}.");
            else
                vOutput.WriteLine($"Can not charge. {nameof(WirelessCharger)} is not in the charging range");
        }
    }
}