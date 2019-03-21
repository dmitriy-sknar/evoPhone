using System;
using EvoPhone.Common.Events;

namespace evoPhone.biz.PhoneParts.SMS {
    public class SMSProvider {

        private static int vSMSNumber;
        public event EventHandler<SMSEventArgs> SMSReceivedHandler;

        public void RaiseSMSReceivedEvent() {
            vSMSNumber++;
            OnSMSReceived();
        }

        protected virtual void OnSMSReceived() {
            SMSReceivedHandler?.Invoke(this, new SMSEventArgs(vSMSNumber));
        }
    }
}
