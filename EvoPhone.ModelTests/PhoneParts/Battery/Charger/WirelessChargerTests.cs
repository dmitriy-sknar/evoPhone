using Microsoft.VisualStudio.TestTools.UnitTesting;
using EvoPhone.Common;
using EvoPhone.Common.Output;

namespace evoPhone.biz.PhoneParts.Battery.Charger.Tests {
    [TestClass()]
    public class WirelessChargerTests {
        [TestMethod()]
        public void WirelessChargerTest() {
            //GIVEN WirelessCharger 
            //AND WirelessCharger is NOT in the reachable range 
            TestOutputContainer testOutputContainer = new TestOutputContainer();
            IOutput outputComponent = new TestOutput(testOutputContainer);
            ICharger charger = new WirelessCharger(outputComponent);
            charger.IsReachableConnected = false;
            string expectedReult = "Can not charge. WirelessCharger is not in the charging range\n";
            //WHEN: try to "charge"
            charger.Charge("Green power");
            //THEN
            Assert.AreEqual(expectedReult, testOutputContainer.Output);
        }
    }
}