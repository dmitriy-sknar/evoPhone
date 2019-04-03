using System;
using evoPhone.biz.PhoneParts.SMS;

namespace EvoPhone.Common.Events {
    public class SMSEventArgs : EventArgs{
        public SMSEventArgs(Message message) {
            Message = message;
        }
        
        public Message Message { get; }
    }
}
