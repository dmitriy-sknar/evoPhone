using System;
using evoPhone.biz.Contacts;

namespace evoPhone.biz.Calls {
    public class Call {
        public Contact Contact { get; }
        public DateTime CallTime { get; }
        public CallDirection CallDirection { get; }

        public Call(Contact contact, DateTime callTime, CallDirection callDirection) {
            Contact = contact;
            CallTime = callTime;
            CallDirection = callDirection;
        }
    }

    public enum CallDirection {
        Incoming = 0,
        Outgoing = 1
    }
}
