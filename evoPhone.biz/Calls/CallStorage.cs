using System;
using System.Collections;
using evoPhone.biz.Calls;
using evoPhone.biz.Calls.Events;
using evoPhone.biz.Contacts;

namespace evoPhone.biz.PhoneParts.SMS {
    public class CallStorage {
        private ContactsListProvider vContactListProvider;
        private ArrayList vContactList;
        public event EventHandler<CallEventArgs> CallReceivedHandler;
        private Random vRandom = new Random();
        private CallList vCallList;

        public CallStorage() {
            vContactListProvider = new ContactsListProvider();
            vContactList = vContactListProvider.GetList();
            vCallList = new CallList(new CallCompararerByDateTime());
            CallReceivedHandler += OnCallReceived;
        }

        public void RaiseSMSReceivedEvent() {
            int callerIndex = vRandom.Next(0, vContactList.Count);
            int callDirection = vRandom.Next(0, 1);
            CallDirection callDirectionValue;
            switch (callDirection) {
                case 0:
                    callDirectionValue = CallDirection.Incoming;
                    break;
                case 1:
                    callDirectionValue = CallDirection.Outgoing;
                    break;
                default:
                    throw new Exception("Provided call direction is not supported");
            }
            ReceiveCall(callerIndex, callDirectionValue);
        }

        protected virtual void ReceiveCall(int callerIndex, CallDirection callDirectionValue) {
            CallReceivedHandler?.Invoke(this,
                new CallEventArgs(
                    new Call(
                        (Contact)vContactList[callerIndex],  
                        DateTime.Now,
                        callDirectionValue)));
        }

        private void OnCallReceived(object sender, CallEventArgs e) {
            vCallList.Add(e.Call);
        }
    }
}