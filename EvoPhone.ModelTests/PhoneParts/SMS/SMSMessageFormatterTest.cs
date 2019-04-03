using System;
using System.Collections.Generic;
using System.Linq;
using evoPhone.biz.PhoneParts.SMS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvoPhone.CommonTests {
    [TestClass]
    public class SMSMessageFormatterTest {

        private SMSMessageFormatter vSmsMessageFormatter;
        private Dictionary<int, string> vFormatterDictionary;

        [TestInitialize]
        public void Initialize() {
            vSmsMessageFormatter = new SMSMessageFormatter();
            vFormatterDictionary = vSmsMessageFormatter.GetFormattersDictionary();
        }

        [TestMethod]
        public void FormatNoneTest() {
            //GIVEN test message and a Formatter that formats the message
            Message testmsg = new Message(1, "Message received", new DateTime(2019, 01, 01));
            string expmsg = "Message received";
            var key = vFormatterDictionary.FirstOrDefault(x => x.Value == "None").Key;
            var formatter = vSmsMessageFormatter.GetFormatter(key);
            //WHEN format action is executed
            string formmsg = formatter(testmsg);
            //THEN formatted message becomes formatted as expected 
            Assert.AreEqual(expmsg, formmsg);
        }

        [TestMethod]
        public void FormatStartTimeTest() {
            //GIVEN test message and a Formatter that formats the message
            string dt = new DateTime(2019, 01, 01).ToString();
            Message testmsg = new Message(1, "Message received", new DateTime(2019, 01, 01));
            string expmsg = $"[{dt}] Message received";
            var key = vFormatterDictionary.FirstOrDefault(x => x.Value == "Start with DateTime").Key;
            var formatter = vSmsMessageFormatter.GetFormatter(key);
            //WHEN format action is executed
            string formmsg = formatter(testmsg);
            //THEN formatted message becomes formatted as expected 
            Assert.AreEqual(expmsg, formmsg);
        }

        [TestMethod]
        public void FormatEndTimeTest() {
            //GIVEN test message and a Formatter that formats the message
            string dt = new DateTime(2019, 01, 01).ToString();
            Message testmsg = new Message(1, "Message received", new DateTime(2019, 01, 01));
            string expmsg = $"Message received [{dt}]";
            var key = vFormatterDictionary.FirstOrDefault(x => x.Value == "End with DateTime").Key;
            var formatter = vSmsMessageFormatter.GetFormatter(key);
            //WHEN format action is executed
            string formmsg = formatter(testmsg);
            //THEN formatted message becomes formatted as expected 
            Assert.AreEqual(expmsg, formmsg);
        }

        [TestMethod]
        public void FormatCustomTest() {
            //GIVEN test message and a Formatter that formats the message
            Message testmsg = new Message(1, "Message received", new DateTime(2019, 01, 01));
            string expmsg = "Message received. \nDo not forget donate to wikipedia.org.\nLet the knowledgebase be alive!";
            var key = vFormatterDictionary.FirstOrDefault(x => x.Value == "Custom").Key;
            var formatter = vSmsMessageFormatter.GetFormatter(key);
            //WHEN format action is executed
            string formmsg = formatter(testmsg);
            //THEN formatted message becomes formatted as expected 
            Assert.AreEqual(expmsg, formmsg);
        }

        [TestMethod]
        public void FormatLowercaseTest() {
            //GIVEN test message and a Formatter that formats the message
            Message testmsg = new Message(1, "Message received", new DateTime(2019, 01, 01));
            string expmsg = "message received";
            var key = vFormatterDictionary.FirstOrDefault(x => x.Value == "lower case").Key;
            var formatter = vSmsMessageFormatter.GetFormatter(key);
            //WHEN format action is executed
            string formmsg = formatter(testmsg);
            //THEN formatted message becomes formatted as expected 
            Assert.AreEqual(expmsg, formmsg);
        }

        [TestMethod]
        public void FormatUppercaseTest() {
            //GIVEN test message and a Formatter that formats the message
            Message testmsg = new Message(1, "Message received", new DateTime(2019, 01, 01));
            string expmsg = "MESSAGE RECEIVED";
            var key = vFormatterDictionary.FirstOrDefault(x => x.Value == "UPPER CASE").Key;
            var formatter = vSmsMessageFormatter.GetFormatter(key);
            //WHEN format action is executed
            string formmsg = formatter(testmsg);
            //THEN formatted message becomes formatted as expected 
            Assert.AreEqual(expmsg, formmsg);
        }
    }
}
