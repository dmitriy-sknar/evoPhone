using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoPhone.biz {
    class NiMhBattery : BaseBattery{
        public override void Charge()
        {
            Console.WriteLine("Nicel Metal Hydrid battery charging");
        }

        public override string ToString() {
            return "NiMh battery";
        }
    }
}
