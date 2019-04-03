using System;
using EvoPhone.Common.Events;

namespace evoPhone.biz.PhoneParts.SMS {
    internal class SMSProvider {

        private static int vSMSNumber;
        private static int vSmsSender;

        public event EventHandler<SMSEventArgs> SMSReceivedHandler;

        public void RaiseSMSReceivedEvent() {
            vSMSNumber++;
            vSmsSender = new Random().Next(0, 4);
            ReceiveSms();
        }

        protected virtual void ReceiveSms() {
            SMSReceivedHandler?.Invoke(this, new SMSEventArgs(new Message(vSmsSender, "Message number #" + vSMSNumber + " received!", DateTime.Now)));
        }
    }
}
