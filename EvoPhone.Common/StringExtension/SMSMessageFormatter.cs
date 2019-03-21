using System;
using System.Collections.Generic;

namespace EvoPhone.Common.StringExtension {
    public class SMSMessageFormatter {
        public delegate string FormatDelegate(string test);

        private Dictionary<int, FormatDelegate> formattersDictionary;
        
        public SMSMessageFormatter() {
            formattersDictionary = new Dictionary<int, FormatDelegate>();
            formattersDictionary.Add(0, NoFormat);
            formattersDictionary.Add(1, FormatWithTimeInTheStart);
            formattersDictionary.Add(2, FormatWithTimeInTheEnd);
            formattersDictionary.Add(3, CustomFormat);
            formattersDictionary.Add(4, FormatWithLowerCase);
            formattersDictionary.Add(5, FormatWithUpperCase);
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

        private static string NoFormat(string message) {
            return $"{message}";
        }

        private static string FormatWithTimeInTheStart(string message) {
            return $"[{DateTime.Now}] {message}";
        }

        private static string FormatWithTimeInTheEnd(string message) {
            return $"{message} [{DateTime.Now}]";
        }

        private static string CustomFormat(string message) {
            return $"{message}. \nDo not forget donate to wikipedia.org.\nLet the knowledgebase be alive!";
        }

        private static string FormatWithLowerCase(string message) {
            return $"{message.ToLower()}";
        }

        private static string FormatWithUpperCase(string message) {
            return $"{message.ToUpper()}";
        }


    }
}