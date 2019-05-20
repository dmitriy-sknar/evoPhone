using System;
using System.Collections.Generic;

namespace evoPhone.biz.Calls.Comparators {
    public class CallComparByContactAndDirect : IComparer<Call> {
        public int Compare(Call first, Call second) {
            if (first == null || second == null) throw new ArgumentException("Cann't compare on NotReferenced object");
            int primary = first.Contact.Name.CompareTo(second.Contact.Name);
            if (primary != 0) return primary;
            return second.CallDirection.CompareTo(first.CallDirection);
        }
    }
}