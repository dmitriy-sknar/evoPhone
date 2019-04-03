using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace evoPhone.biz.PhoneParts.SMS.Tests {
    [TestClass()]
    public class SMSMessageFilterTests {
        private List<Message> vMessageList;

        [TestInitialize]
        public void Initialize() {
            vMessageList = new List<Message>();
            vMessageList.Add(new Message(1, "Message #1 received", new DateTime(2019, 01, 01)));
            vMessageList.Add(new Message(2, "Message #2 received", new DateTime(2019, 01, 02)));
            vMessageList.Add(new Message(2, "Message #2 received", new DateTime(2019, 01, 03)));
            vMessageList.Add(new Message(2, "Message #3 received", new DateTime(2019, 01, 04)));
            vMessageList.Add(new Message(4, "Message #4 received", new DateTime(2019, 01, 04)));
            vMessageList.Add(new Message(5, "Message #5 received", new DateTime(2019, 01, 05)));
        }

        [TestMethod()]
        public void AllFiltersTest() {
            //GIVEN
            List<Message> resultList;
            //WHEN
            resultList = SMSMessageFilter.AllFilters(vMessageList, 380509876540, "#2", new DateTime(2019, 01, 02), new DateTime(2019, 01, 02));
            //THEN
            Assert.AreEqual(resultList.Count, 1);
        }

        [TestMethod()]
        public void NumberFilterTest() {
            //GIVEN
            List<Message> resultList;
            //WHEN
            resultList = SMSMessageFilter.NumberFilter(vMessageList, 380680000001);
            //THEN
            Assert.AreEqual(resultList.Count, 1);
        }

        [TestMethod()]
        public void TextFilterTest() {
            //GIVEN
            List<Message> resultList;
            //WHEN
            resultList = SMSMessageFilter.TextFilter(vMessageList, "#3");
            //THEN
            Assert.AreEqual(resultList.Count, 1);
        }

        [TestMethod()]
        public void DateFilterTest() {
            //GIVEN
            List<Message> resultList;
            //WHEN
            resultList = SMSMessageFilter.DateFilter(vMessageList, new DateTime(2019, 01, 02), new DateTime(2019, 01, 04));
            //THEN
            Assert.AreEqual(resultList.Count, 4);
        }
    }
}