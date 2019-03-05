namespace evoPhone.biz {
    public abstract class PhoneBuilder
    {
        protected Mobile mobile;

        public Mobile Mobile
        {
            get { return mobile; }
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