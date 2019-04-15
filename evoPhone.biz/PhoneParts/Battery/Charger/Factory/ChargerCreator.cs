namespace evoPhone.biz.PhoneParts.Battery.Charger.Factory {
    public abstract class ChargerCreator {
        public abstract IInteractiveCharger CreateCharger(biz.Battery battery, int chargeDelay, int dischargeDelay);
    }
}
