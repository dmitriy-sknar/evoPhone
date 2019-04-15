using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace evoPhone.biz.Tests {
    [TestClass()]
    public class PowerBatteryTests {

        [TestMethod()]
        public void ChargeTest() {
            PowerBattery powerBattery = new PowerBattery();
            for (int i = 1; i < 110; i++) {
                powerBattery.Discharge();
            }
            Assert.AreEqual(powerBattery.ChargeLevel, 0);
        }

        [TestMethod()]
        public void DischargeTest() {
            PowerBattery powerBattery = new PowerBattery();
            for (int i = 1; i < 110; i++) {
                powerBattery.Charge();
            }
            Assert.AreEqual(powerBattery.ChargeLevel, 100);
        }
    }   
}