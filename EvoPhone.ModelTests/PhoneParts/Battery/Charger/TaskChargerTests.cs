using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using evoPhone.biz.PhoneParts.Battery.Charger.Factory;
using EvoPhone.Common.DateTime;

namespace evoPhone.biz.PhoneParts.Battery.Charger.Tests {
    [TestClass()]
    public class TaskChargerTests {

        private Mobile vMobile;

        [TestInitialize]
        public void Initialize() {
            PhoneBuilder builder = new SimCorpPhoneBuilder();
            var phoneConstructor = new PhoneConstructor(builder);
            phoneConstructor.Construct();
            vMobile = builder.GetMobile;
            vMobile.SetAllActive();
        }

        [TestMethod()]
        public void ChargeTest() {
            //GIVEN Task-based charger
            ChargerCreator chargerCreator = new TaskChargerCreator();
            IInteractiveCharger charger = chargerCreator.CreateCharger(vMobile.Battery, TimeUnits.MilliSecond(), TimeUnits.MilliSecond());
            charger.ChargeLevelChangedHandler += OnBatteryChargeLevelChanged;
            vMobile.ChargerComponent = charger;
            //AND charging state on Mobile Phone is set to charging state
            vMobile.ChargerComponent.IsReachableConnected = true;
            //WHEN waiting 2 second to charge
            Thread.Sleep(2000);
            //THEN phone is charged
            Assert.AreEqual(vMobile.Battery.ChargeLevel, 100);
        }

        [TestMethod()]
        public void DischargeTest() {
            //GIVEN Task-based charger
            ChargerCreator chargerCreator = new TaskChargerCreator();
            IInteractiveCharger charger = chargerCreator.CreateCharger(vMobile.Battery, TimeUnits.MilliSecond(), TimeUnits.MilliSecond());
            charger.ChargeLevelChangedHandler += OnBatteryChargeLevelChanged;
            vMobile.ChargerComponent = charger;
            //AND charging state on Mobile Phone is set to discharging state
            vMobile.ChargerComponent.IsReachableConnected = false;
            //WHEN waiting 4 second to discharge
            Thread.Sleep(1000);
            //THEN phone is discharging
            Assert.IsTrue(vMobile.Battery.ChargeLevel<100);
        }

        private void OnBatteryChargeLevelChanged(object sender, EventArgs eventArgs) {}
    }
}