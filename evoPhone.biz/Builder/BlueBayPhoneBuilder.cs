namespace evoPhone.biz.Builder {
    public class BlueBayPhoneBuilder : PhoneBuilder {
        public BlueBayPhoneBuilder() {
            vMobile = new Mobile("BlueBay Mobile Phone");
        }

        public override void BuildKeyboard() {
            vMobile["screen"] = new IPSScreen(6.0, 1280, 1920, 32);
        }

        public override void BuildCase() {
            vMobile["case"] = new MaterialCase(130, 85, 10, CaseMaterial.Plastic);
        }

        public override void BuildScreen() {
            vMobile["keyboard"] = new BacklightKeyboard();
        }

        public override void BuildDynamic() {
            vMobile["dynamic"] = new Speaker(100, true);
        }

        public override void BuildBattery() {
            vMobile["battery"] = new PowerBattery(BatteryType.PowerNiMh, 6000, 65, 50, 7);
        }

        public override void BuildMicrophone() {
            vMobile["microphone"] = new Microphone(70, false);
        }

        public override void BuildSimCard() {
            vMobile["simcard"] = new Simcard(SimCardType.G4, SimCardFormFactor.Micro);
        }
    }
}