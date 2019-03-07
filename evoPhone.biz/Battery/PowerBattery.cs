using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoPhone.biz {
    public class PowerBattery : BaseBattery {
        public PowerBattery() : base()
        {
            this.BatteryType = BatteryType.PowerLiPo;
        }

        public PowerBattery(BatteryType batteryType, int volume, int height, int width, int length) 
            : base(volume, height, width, length) {
            this.BatteryType = batteryType;
        }

        private BatteryType batteryType;

        public BatteryType BatteryType
        {
            get { return batteryType; }
            set { batteryType = value; }
        }

        public override void Charge()
        {
            Console.WriteLine(BatteryType + " battery charging");
        }

        public override string ToString() {
            return BatteryType + " battery";
        }
    }

    public enum BatteryType
    {
        PowerLiPo,
        PowerNiCd,
        PowerNiMh
    }
}
