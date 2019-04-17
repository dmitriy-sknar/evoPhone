using System;

namespace evoPhone.biz.Calls.Events {
    public class CallEventArgs : EventArgs{
        public CallEventArgs(Call call) {
            Call = call;
        }
        
        public Call Call { get; }
    }
}
