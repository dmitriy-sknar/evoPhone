using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using evoPhone.biz.Calls.Comparators;

namespace evoPhone.biz.Calls.Tests {
    [TestClass()]
    public class CompararerByDateTimeTests {
        private DateTime vDT1, vDT2, vDT3, vDT4;
        private CompararerByDateTime comparer = new CompararerByDateTime();

        [TestInitialize]
        public void TestInitialize() {
            vDT1 = new DateTime(2019, 01, 01, 01, 00, 10);
            vDT2 = new DateTime(2019, 01, 01, 01, 00, 10);
            vDT3 = new DateTime(2019, 01, 01, 01, 01, 10);
            vDT4 = new DateTime(2019, 01, 01, 01, 02, 10);
        }

        [TestMethod()]
        public void CompareTest() {

            //GIVEN two DateTime objects with same date AND time
            //EXPECTED two DateTimes are equal
            Assert.AreEqual(comparer.Compare(vDT1, vDT2), 0);

            //GIVEN two DateTime objects: First has time EARLIER than Second
            //EXPECTED two DateTimes are NOT equal
            Assert.AreEqual(comparer.Compare(vDT1, vDT3), 1);

            //GIVEN two DateTime objects: First has time LATER than Second
            //EXPECTED two DateTimes are NOT equal
            Assert.AreEqual(comparer.Compare(vDT3, vDT4), 1);
        }
    }
}