namespace evoPhone.biz.PhoneParts.Battery.Charger.Factory {
    public class ThreadChargerCreator : ChargerCreator {
        public override IInteractiveCharger CreateCharger(biz.Battery battery, int chargeDelay, int dischargeDelay) {
            return new ThreadedCharger(battery, chargeDelay, dischargeDelay);
        }
    }
}
