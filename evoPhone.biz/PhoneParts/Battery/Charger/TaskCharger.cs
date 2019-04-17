using System;
using System.Threading.Tasks;
using EvoPhone.Common.DateTime;

namespace evoPhone.biz.PhoneParts.Battery.Charger {
    public class TaskCharger : IInteractiveCharger {
        private Task vBatteryChargingTask;
        private Task vBatteryDishargingTask;
        public int ChargeDelay { get; }
        public int DischargeDelay { get; }

        private biz.Battery Battery { get; }
        public bool IsReachableConnected { get; set; }

        public TaskCharger(biz.Battery battery, int chargeDelay, int dischargeDelay) {
            Battery = battery;
            ChargeDelay = chargeDelay;
            DischargeDelay = dischargeDelay;
            IsReachableConnected = false;
            CreateTasks();
        }

        private void CreateTasks() {
            vBatteryChargingTask = Task.Factory.StartNew(() => {
                while (true) {
                    if (IsReachableConnected) {
                        Task.Delay(ChargeDelay).Wait();
                        Battery.Charge();
                        OnBatteryChargeLevelChanged();
                        
                        }
                }
            });

            vBatteryDishargingTask = Task.Factory.StartNew(() => {
                while (true) {
                    if (!IsReachableConnected) {
                        Task.Delay(DischargeDelay).Wait(); 
                        Battery.Discharge();
                        OnBatteryChargeLevelChanged();
                    }
                }
            });
        }

        public void Charge(object energy) {}

        public void OnBatteryChargeLevelChanged() {
            //ChargeLevelChangedHandler?.Invoke(this, EventArgs.Empty);
            ChargeLevelChangedHandler?.BeginInvoke(this, EventArgs.Empty, null, null);
        }

        public event EventHandler ChargeLevelChangedHandler;
    }
}