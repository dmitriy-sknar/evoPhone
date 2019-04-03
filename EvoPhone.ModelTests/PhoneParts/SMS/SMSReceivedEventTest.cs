using System;
using evoPhone.biz;
using EvoPhone.Common;
using EvoPhone.Common.Events;
using EvoPhone.Common.Output;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvoPhone.ModelTests.PhoneParts.SMS {
    [TestClass]
    public class SMSReceivedEventTest {
        private Mobile vMobile;
        private IOutput vOutputComponent;
        private TestOutputContainer vTestOutputContainer;

        [TestInitialize]
        public void Initialize() {
            PhoneBuilder builder = new SimCorpPhoneBuilder();
            var phoneConstructor = new PhoneConstructor(builder);
            phoneConstructor.Construct();
            vMobile = builder.GetMobile;
            vMobile.SetAllActive();
        }

        [TestMethod]
        public void TestMethod1() {
            //GIVEN Mobile phone with Message Storage that incapsulates Message Provider that in its turn can handle ReceiveSms event
            //AND on this event vTestOutputContainer.Output property is populated with test message
            vTestOutputContainer = new TestOutputContainer();
            vOutputComponent = new TestOutput(vTestOutputContainer);
            vMobile.SmsStorage.SMSStorageChangeHandler += OnSMSStorageChanged;
            string expmsg = "Message number #1 received!";
            //WHEN ReceiveSms event is raised
            vMobile.SmsStorage.RaiseSMSReceivedEvent();
            //THEN vTestOutputContainer.Output property is populated with correct Message message
            bool contains = vTestOutputContainer.Output.Contains("Message number #1 received!");
            Assert.IsTrue(contains);
        }

        private void OnSMSStorageChanged(object sender, SMSEventArgs eventArgs) {
            string message = eventArgs.Message.ToString();
            vOutputComponent.WriteLine(message);
        }
    }
}
