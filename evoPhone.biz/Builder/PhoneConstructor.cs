namespace evoPhone.biz {
    public class PhoneConstructor {
        private readonly PhoneBuilder vPhoneBuilder;

        public PhoneConstructor(PhoneBuilder phoneBuilder) {
            vPhoneBuilder = phoneBuilder;
        }

        public void Construct() {
            vPhoneBuilder.BuildKeyboard();
            vPhoneBuilder.BuildCase();
            vPhoneBuilder.BuildScreen();
            vPhoneBuilder.BuildDynamic();
            vPhoneBuilder.BuildBattery();
            vPhoneBuilder.BuildMicrophone();
            vPhoneBuilder.BuildSimCard();
        }
    }
}