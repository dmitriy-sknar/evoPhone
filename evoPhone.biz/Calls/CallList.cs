using System;
using System.Collections.Generic;

namespace evoPhone.biz.Calls {
    public class CallList {

        private SortedList<DateTime, Call> List;

        public CallList(IComparer<DateTime> comparer) {
            List = new SortedList<DateTime, Call>(comparer);
        }

        public void Add(Call call) {
            List.Add(call.CallTime, call);
        }

        public void Clear() {
            List.Clear();
        }

        public void Remove(Call call) {
            List.Remove(call.CallTime);
        }

        public SortedList<DateTime, Call> Get() {
            return List;
        }

        public Call GetRecentCall() {
            if (List.Count > 0) 
            return List.Values[0];
            return null;
        }

        public Call GetOldestCall() {
            if (List.Count > 0) {
                int callIndex = List.Count - 1;
                return List.Values[callIndex];
            }
            return null;
        }
    }
}
