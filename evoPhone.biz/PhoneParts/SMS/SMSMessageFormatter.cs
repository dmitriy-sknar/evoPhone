using System;
using System.Collections.Generic;

namespace evoPhone.biz.PhoneParts.SMS {
    public class SMSMessageFormatter {
        public delegate string FormatDelegate(Message message);

        private Dictionary<int, FormatDelegate> formattersDictionary;
        
        public SMSMessageFormatter() {
            formattersDictionary = new Dictionary<int, FormatDelegate> {
                {0, NoFormat},
                {1, FormatWithTimeInTheStart},
                {2, FormatWithTimeInTheEnd},
                {3, CustomFormat},
                {4, FormatWithLowerCase},
                {5, FormatWithUpperCase}
            };
        }

        public FormatDelegate GetFormatter(int index) {
            if (formattersDictionary.ContainsKey(index)) {
                return formattersDictionary[index];
            }
            if (index == -1) return NoFormat;
            
            throw new ArgumentException();          
        }
        public Dictionary<int, string> GetFormattersDictionary() {
            return new Dictionary<int, string>() {
                {0, "None"},
                {1, "Start with DateTime"},
                {2, "End with DateTime"},
                {3, "Custom"},
                {4, "lower case"},
                {5, "UPPER CASE"},
            };
        }

        private string NoFormat(Message message) {
            return message.Text;
        }

        private string FormatWithTimeInTheStart(Message message) { 
            return $"[{message.ReceivingTime}] {message.Text}";
        }

        private string FormatWithTimeInTheEnd(Message message) {
            return $"{message.Text} [{message.ReceivingTime}]";
        }

        private string CustomFormat(Message message) {
            return $"{message.Text}. \nDo not forget donate to wikipedia.org.\nLet the knowledgebase be alive!";
        }

        private string FormatWithLowerCase(Message message) {
            return $"{message.Text.ToLower()}";
        }

        private string FormatWithUpperCase(Message message) {
            return $"{message.Text.ToUpper()}";
        }       
    }
}