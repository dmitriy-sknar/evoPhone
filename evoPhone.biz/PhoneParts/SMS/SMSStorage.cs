using System;
using System.Collections.Generic;
using EvoPhone.Common.Events;

namespace evoPhone.biz.PhoneParts.SMS {
    public class SMSStorage {
        public List<Message> List { get; }
        private SMSProvider SmsProvider { get; }
        public event EventHandler<SMSEventArgs> SMSStorageChangeHandler;

        public SMSStorage() {
            List = new List<Message>();
            SmsProvider = new SMSProvider();
            SmsProvider.SMSReceivedHandler += OnSMSReceived;
        }

        public void Clear() {
            List.Clear();
            //TODO type of event like Add, Remove etc. So far not used.
        }

        public void Add(Message message) {
            List.Add(message);
            OnSMSStorageChanged(this, new SMSEventArgs(message));
        }

        public void Remove(Message message) {
            List.Remove(message);
            //TODO type of event like Add, Remove etc. So far not used.
        }

        public void RaiseSMSReceivedEvent() {
            SmsProvider.RaiseSMSReceivedEvent();
        }

        private void OnSMSReceived(object sender, SMSEventArgs eventArgs) {
            Add(eventArgs.Message);
        }

        private void OnSMSStorageChanged(object sender, SMSEventArgs eventArgs) {
            SMSStorageChangeHandler?.Invoke(this, eventArgs);
        }
    }
}
