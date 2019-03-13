using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoPhone.biz.PhoneParts.Battery.Charger {
    public interface ICharger {
        void Charge(object energy);
        bool IsReachableConnected { get; set; }
    }
}
