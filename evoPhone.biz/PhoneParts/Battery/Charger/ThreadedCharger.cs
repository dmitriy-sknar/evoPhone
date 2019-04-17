using System;
using System.Threading;

namespace evoPhone.biz.PhoneParts.Battery.Charger {
    public class ThreadedCharger : IInteractiveCharger {
        private Thread vBatteryChargingThread;
        private biz.Battery Battery { get; }
        public int ChargeDelay { get; }
        public int DischargeDelay { get; }

        public ThreadedCharger(biz.Battery battery, int chargeDelay, int dischargeDelay) {
            Battery = battery;
            ChargeDelay = chargeDelay;
            DischargeDelay = dischargeDelay;
            IsReachableConnected = false;
            vBatteryChargingThread = new Thread(Charge) {IsBackground = true};
            vBatteryChargingThread.Start();
        }

        public bool IsReachableConnected { get; set; }

        public void Charge(object energy) {
            while (true) {
                if (IsReachableConnected) {
                    Thread.Sleep(ChargeDelay); 
                    Battery.Charge();
                }
                else {
                    Thread.Sleep(DischargeDelay);
                    Battery.Discharge();
                }
                OnBatteryChargeLevelChanged();
            }
        }

        public void OnBatteryChargeLevelChanged() {
            //ChargeLevelChangedHandler?.Invoke(this, EventArgs.Empty);
            ChargeLevelChangedHandler?.BeginInvoke(this, EventArgs.Empty, null, null);
        }

        public event EventHandler ChargeLevelChangedHandler;
    }
}