using System;

namespace evoPhone.biz.PhoneParts.Battery.Charger {
    public interface IInteractiveCharger : ICharger {
        void OnBatteryChargeLevelChanged();

        event EventHandler ChargeLevelChangedHandler;
    }
}
