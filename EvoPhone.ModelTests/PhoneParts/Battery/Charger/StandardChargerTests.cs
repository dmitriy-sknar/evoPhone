using Microsoft.VisualStudio.TestTools.UnitTesting;
using EvoPhone.Common;
using EvoPhone.Common.Output;

namespace evoPhone.biz.PhoneParts.Battery.Charger.Tests {
    [TestClass()]
    public class StandardChargerTests {
        [TestMethod()]
        public void StandardChargerTest() {
            //GIVEN StandardCharger 
            //AND StandardCharger is in the reachable range 
            TestOutputContainer testOutputContainer = new TestOutputContainer();
            IOutput outputComponent = new TestOutput(testOutputContainer);
            ICharger charger = new StandardCharger(outputComponent);
            charger.IsReachableConnected = true;
            string expectedReult = "StandardCharger charger. \nCharging the battery with Green power.\n";
            //WHEN: try to "charge"
            charger.Charge("Green power");
            //THEN
            Assert.AreEqual(expectedReult, testOutputContainer.Output);
        }
    }
}