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
            //GIVEN Mobile phone with SMS Provider that can handle OnSMSReceived event
            //AND on this event vTestOutputContainer.Output property is populated with SMS message
            vTestOutputContainer = new TestOutputContainer();
            vOutputComponent = new TestOutput(vTestOutputContainer);
            vMobile.SmsProvider.SMSReceivedHandler += OnSMSReceived;
            string expmsg = "Message number 1\n";
            //WHEN OnSMSReceived event is raised
            vMobile.SmsProvider.RaiseSMSReceivedEvent();
            //THEN vTestOutputContainer.Output property is populated with correct SMS message
            Assert.AreEqual(expmsg, vTestOutputContainer.Output);
        }

        private void OnSMSReceived(object sender, SMSEventArgs eventArgs) {
            string message = eventArgs.SMS;
            vOutputComponent.WriteLine(message);
        }
    }
}
