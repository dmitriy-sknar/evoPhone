using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoPhone.biz {
    class SimCorpPhoneBuilder : PhoneBuilder
    {

        public SimCorpPhoneBuilder()
        {
            mobile = new Mobile("SimCorp Mobile Phone");
        }

        public override void BuildKeyboard()
        {
            mobile["screen"] = new IPSScreen(5.0, 720, 1280, 24);
        }

        public override void BuildCase()
        {
            mobile["case"] = new MaterialCase(120, 80, 8, CaseMaterial.Metal);
        }

        public override void BuildScreen()
        {
            mobile["keyboard"] = new BaseKeyboard();
        }

        public override void BuildDynamic()
        {
            mobile["dynamic"] = new Dynamic(100, true);
        }

        public override void BuildBattery()
        {
            mobile["battery"] = new PowerBattery(BatteryType.PowerLiPo, 3000, 60, 40, 4);
        }

        public override void BuildMicrophone()
        {
            mobile["microphone"] = new Microphone(50, false);
        }

        public override void BuildSimCard()
        {
            mobile["simcard"] = new Simcard(SimCardType.G4);
        }
    }
}