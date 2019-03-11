namespace evoPhone.biz {
    public abstract class PhoneBuilder {
        protected Mobile vMobile;

        public Mobile GetMobile {
            get { return vMobile; }
        }

        public abstract void BuildKeyboard();
        public abstract void BuildCase();
        public abstract void BuildScreen();
        public abstract void BuildDynamic();
        public abstract void BuildBattery();
        public abstract void BuildMicrophone();
        public abstract void BuildSimCard();
    }
}