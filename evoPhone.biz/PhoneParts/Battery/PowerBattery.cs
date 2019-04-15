using System;

namespace evoPhone.biz {
    public class PowerBattery : BaseBattery {

        public PowerBattery() {
            BatteryType = BatteryType.PowerLiPo;
            ChargeLevel = 100;
        }

        public PowerBattery(BatteryType batteryType, int volume, int height, int width, int length)
            : base(volume, height, width, length) {
            this.BatteryType = batteryType;
            ChargeLevel = 100;
        }

        public BatteryType BatteryType { get; private set; }

        public override void Charge() {
            if (ChargeLevel < 100) 
                ChargeLevel++;
        }

        public override void Discharge() {
            if (ChargeLevel > 0)
                ChargeLevel--;
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