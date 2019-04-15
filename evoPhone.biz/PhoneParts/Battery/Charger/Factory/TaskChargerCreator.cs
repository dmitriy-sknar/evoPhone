namespace evoPhone.biz.PhoneParts.Battery.Charger.Factory {
    public class TaskChargerCreator : ChargerCreator {
        public override IInteractiveCharger CreateCharger(biz.Battery battery, int chargeDelay, int dischargeDelay) {
            return new TaskCharger(battery, chargeDelay, dischargeDelay);
        }
    }
}
