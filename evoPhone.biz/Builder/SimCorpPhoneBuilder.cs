namespace evoPhone.biz {
    public class SimCorpPhoneBuilder : PhoneBuilder {
        public SimCorpPhoneBuilder() {
            vMobile = new Mobile("SimCorp Mobile Phone");
        }

        public override void BuildKeyboard() {
            vMobile["screen"] = new IPSScreen(5.0, 720, 1280, 24);
        }

        public override void BuildCase() {
            vMobile["case"] = new MaterialCase(120, 80, 8, CaseMaterial.Metal);
        }

        public override void BuildScreen() {
            vMobile["keyboard"] = new BaseKeyboard();
        }

        public override void BuildDynamic() {
            vMobile["dynamic"] = new Speaker(100, true);
        }

        public override void BuildBattery() {
            IPhonePart battery = new PowerBattery(BatteryType.PowerLiPo, 3000, 60, 40, 4);
            vMobile["battery"] = battery;
            vMobile.Battery = (Battery) battery;
        }

        public override void BuildMicrophone() {
            vMobile["microphone"] = new Microphone(50, false);
        }

        public override void BuildSimCard() {
            vMobile["simcard"] = new Simcard(SimCardType.G4, SimCardFormFactor.Nano);
        }
    }
}