using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EvoPhone.Common.Events;

namespace evoPhone.biz.PhoneParts.SMS.Tests {
    [TestClass()]
    public class SMSStorageTests {
        private SMSStorage vSmsStorage;
        private int counter;

        [TestInitialize]
        public void Initialize() {
            vSmsStorage = new SMSStorage();
            counter = 0;
        }

        [TestMethod()]
        public void AddTest() {
            vSmsStorage.SMSStorageChangeHandler += OnSmsStorageChangeHandler;
            vSmsStorage.Add(new Message(1, "text", new DateTime()));
            Assert.AreEqual(counter, 1);
        }

        private void OnSmsStorageChangeHandler(object sender, SMSEventArgs smsEventArgs) {
            counter++;
        }

        [TestMethod()]
        public void RaiseSMSReceivedEventTest() {
            vSmsStorage.RaiseSMSReceivedEvent();    
            Assert.AreEqual(vSmsStorage.List.Count, 1);
        }

        //TODO other test methods for remove, reset etc. to be done on such functionality inmplementation. Raise event on this (development) =)
    }
}