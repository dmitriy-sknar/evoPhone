namespace evoPhone.biz.PhoneParts.Battery.Charger {
    public interface ICharger {
        void Charge(object energy);
        bool IsReachableConnected { get; set; }
    }
}
