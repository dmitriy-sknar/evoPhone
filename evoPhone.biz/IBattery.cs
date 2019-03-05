using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoPhone.biz {
    interface IBattery
    {
        void Charge();

        int Volume { get; }

        int[] Size { get; }
    }
}
