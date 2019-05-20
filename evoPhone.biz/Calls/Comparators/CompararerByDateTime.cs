using System;
using System.Collections.Generic;

namespace evoPhone.biz.Calls.Comparators {
    public class CompararerByDateTime : IComparer<DateTime> {
        public int Compare(DateTime first, DateTime second) {
            if (first == null || second == null) throw new ArgumentException("Cann't compare on NotReferenced object");
            return DateTime.Compare(second, first);
        }
    }
}