using System;

namespace EvoPhone.Common.Events {
    public class SMSEventArgs : EventArgs{
        public SMSEventArgs(int index) {
            SMS = "Message number " + index;
        }
        public string SMS { get; }
    }
}
