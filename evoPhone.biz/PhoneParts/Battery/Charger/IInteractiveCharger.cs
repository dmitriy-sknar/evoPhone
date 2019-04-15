using System;

namespace evoPhone.biz.PhoneParts.Battery.Charger {
    public interface IInteractiveCharger : ICharger {
        void Charge(object energy);
        bool IsReachableConnected { get; set; }
        void OnBatteryChargeLevelChanged();

        event EventHandler ChargeLevelChangedHandler;
    }
}
