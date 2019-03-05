using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoPhone.biz {
    class LiPoBattery : BaseBattery {
        public override void Charge()
        {
            Console.WriteLine("LiPo battery charging");
        }

        public override string ToString() {
            return "LiPo battery";
        }
    }
}
