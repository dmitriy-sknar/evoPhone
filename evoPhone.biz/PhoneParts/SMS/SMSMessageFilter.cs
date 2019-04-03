using System;
using System.Collections.Generic;
using System.Linq;

namespace evoPhone.biz.PhoneParts.SMS {
    public static class SMSMessageFilter {
        public static List<Message> AllFilters(List<Message> messageList, long numberFilter, string messageFilter,
            DateTime startDateTime, DateTime endDateTime) {
            List<Message> preparedMessages = new List<Message>(messageList);
            preparedMessages = new List<Message>(messageList);
            preparedMessages = NumberFilter(preparedMessages, numberFilter);
            preparedMessages = TextFilter(preparedMessages, messageFilter);
            preparedMessages = DateFilter(preparedMessages, startDateTime, endDateTime);
            return preparedMessages;
        }

        public static List<Message> NumberFilter(List<Message> vMessageList, long numberFilter) {
            List<Message> preparedMessages = new List<Message>(vMessageList);
            if (numberFilter != -1 && numberFilter != 0) {
                preparedMessages = preparedMessages.Where(message => message.Contact.Number == numberFilter).ToList();
            }
            return preparedMessages;
        }

        public static List<Message> TextFilter(List<Message> vMessageList, string messageFilter) {
            List<Message> preparedMessages = new List<Message>(vMessageList);
            if (!messageFilter.Equals("") && !messageFilter.Equals("Search")) {
                preparedMessages = preparedMessages.Where(message => message.Text.Contains(messageFilter)).ToList();
            }
            return preparedMessages;
        }

        public static List<Message> DateFilter(List<Message> vMessageList, DateTime startDateTime, DateTime endDateTime) {
            List<Message> preparedMessages = new List<Message>(vMessageList);
            preparedMessages = preparedMessages
                .Where(message => message.ReceivingTime.CompareTo(startDateTime) >= 0)
                .Where(message => message.ReceivingTime.CompareTo(endDateTime) <= 0).ToList();
            return preparedMessages;
        }
    }
}