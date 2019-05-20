using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using evoPhone.biz.Calls.Comparators;
using evoPhone.biz.Contacts;

namespace evoPhone.biz.Calls.Tests {
    [TestClass()]
    public class CallListTests {

        private CallList vCallList;
        private Call call1, call2, call3, call4;

        [TestInitialize]
        public void TestInitialize() {
            vCallList = new CallList(new CompararerByDateTime());
            call1 = new Call(new Contact("John Travolta", 380671234567), new DateTime(2019, 01, 01, 01, 01, 10),
                CallDirection.Incoming);
            call2 = new Call(new Contact("Erik Johanson", 380671234568), new DateTime(2019, 01, 01, 01, 01, 15),
                CallDirection.Outgoing);
            call3 = new Call(new Contact("Santa Barbara", 380671234569), new DateTime(2019, 01, 01, 01, 01, 20),
                CallDirection.Incoming);
            call4 = new Call(new Contact("Mike Mayers", 380671234570), new DateTime(2019, 01, 01, 01, 01, 30),
                CallDirection.Outgoing);
            vCallList.Add(call1);
            vCallList.Add(call2);
            vCallList.Add(call3);
            vCallList.Add(call4);
        }

        [TestMethod()]
        public void MostRecentCallTest() {
            //GIVEN CallList with a bunch of calls
            //WHEN CallList should be internally sorted on each call is added
            //THEN check that Calls in the CallList are sorted with descending order basing on call time (first is the latest call)
            Assert.AreEqual(vCallList.GetRecentCall().CallTime, new DateTime(2019, 01, 01, 01, 01, 30));
        }

        [TestMethod()]
        public void OldestCallTest() {
            //GIVEN CallList with a bunch of calls
            //WHEN CallList should be internally sorted on each call is added
            //THEN check that Calls in the CallList are sorted with descending order basing on call time (first is the latest call)
            Assert.AreEqual(vCallList.GetOldestCall().CallTime, new DateTime(2019, 01, 01, 01, 01, 10));
        }

        [TestMethod()]
        public void MostRecentCallAfterDeletionTest() {
            //GIVEN CallList with a bunch of calls
            //WHEN CallList should be internally sorted on each call is added
            //THEN check that Calls in the CallList are sorted with descending order basing on call time (first is the latest call)
            vCallList.Remove(call4);
            Assert.AreEqual(vCallList.GetRecentCall().CallTime, new DateTime(2019, 01, 01, 01, 01, 20));
        }
    }
}