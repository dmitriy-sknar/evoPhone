using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoPhone.biz {
    public class PhoneConstructor {

        public void Construct(PhoneBuilder phoneBuilder)
        {
            phoneBuilder.BuildKeyboard();
            phoneBuilder.BuildCase();
            phoneBuilder.BuildScreen();
            phoneBuilder.BuildDynamic();
            phoneBuilder.BuildBattery();
            phoneBuilder.BuildMicrophone();
            phoneBuilder.BuildSimCard();

        }
    }
}
