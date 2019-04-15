namespace evoPhone.biz {
    public abstract class Battery {
        public abstract void Charge();
        public abstract void Discharge();

        protected int vCapacity;

        protected int[] vSize;
        
        private int vChargeLevel;

        public int ChargeLevel;
    }
}