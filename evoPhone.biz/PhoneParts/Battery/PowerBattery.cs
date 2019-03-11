using System;

namespace evoPhone.biz {
    public class PowerBattery : BaseBattery {
        public PowerBattery() {
            BatteryType = BatteryType.PowerLiPo;
        }

        public PowerBattery(BatteryType batteryType, int volume, int height, int width, int length)
            : base(volume, height, width, length) {
            this.BatteryType = batteryType;
        }

        public BatteryType BatteryType { get; private set; }

        public override void Charge() {
            Console.WriteLine($"{BatteryType} battery is charging");
        }

        public override string ToString() {
            return $"{BatteryType} battery";
        }
    }

    public enum BatteryType {
        PowerLiPo,
        PowerNiCd,
        PowerNiMh
    }
}