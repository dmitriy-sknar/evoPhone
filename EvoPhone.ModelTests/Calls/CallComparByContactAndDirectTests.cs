using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using evoPhone.biz.Calls.Comparators;
using evoPhone.biz.Contacts;

namespace evoPhone.biz.Calls.Tests {
    [TestClass()]
    public class CallComparByContactAndDirectTests {
        private Call vCall1, vCall2, vCall3, vCall4;
        private CallComparByContactAndDirect comparer = new CallComparByContactAndDirect();

        [TestInitialize]
        public void TestInitialize() {
            vCall1 = new Call(new Contact("John Travolta", 380671234567), new DateTime(2019, 01, 01, 01, 01, 10),
                CallDirection.Incoming);
            vCall2 = new Call(new Contact("John Travolta", 380671234567), new DateTime(2019, 01, 01, 01, 01, 10),
                CallDirection.Incoming);
            vCall3 = new Call(new Contact("Santa Barbara", 380671234569), new DateTime(2019, 01, 01, 01, 01, 10),
                CallDirection.Incoming);
            vCall4 = new Call(new Contact("John Travolta", 380671234567), new DateTime(2019, 01, 01, 02, 01, 10),
                CallDirection.Outgoing);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Cann't compare on NotReferenced object")]
        public void CompareTest() {
            //GIVEN two calls with same Contact AND same call direction
            //EXPECTED two call are equal
            Assert.AreEqual(comparer.Compare(vCall1, vCall2), 0);

            //GIVEN two calls with different Contacts AND same call direction
            //EXPECTED two call are NOT equal
            Assert.AreEqual(comparer.Compare(vCall1, vCall3), -1);

            //GIVEN two calls with same Contact AND different call direction
            //EXPECTED two call are NOT equal
            Assert.AreEqual(comparer.Compare(vCall1, vCall4), 1);

            //GIVEN one call and NULL
            //EXPECTED exception is thrown
            comparer.Compare(vCall1, null);
        }
    }
}