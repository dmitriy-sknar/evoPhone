using System;
using System.Collections.Generic;

namespace evoPhone.biz.Calls {
    public class CallCompararerByDateTime : IComparer<DateTime> {
        public int Compare(DateTime first, DateTime second) {
            if (first == null || second == null) throw new Exception("Cann't compare on NotReferenced object");
            return DateTime.Compare(second, first);
        }
    }
}