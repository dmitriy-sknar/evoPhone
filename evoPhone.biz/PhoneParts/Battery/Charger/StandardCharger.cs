using EvoPhone.Common;

namespace evoPhone.biz.PhoneParts.Battery.Charger {
    public class StandardCharger : ICharger {
        private IOutput vOutput;

        public StandardCharger(IOutput output) {
            vOutput = output;
        }

        public bool IsReachableConnected { get; set; }

        public void Charge(object energy) {
            if (IsReachableConnected) vOutput.WriteLine($"{nameof(StandardCharger)} charger. \nCharging the battery with {energy}.");
            else vOutput.WriteLine($"Can not charge. {nameof(StandardCharger)} is not connected");
        }
    }
}
