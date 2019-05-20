using System;
using System.Collections.Generic;
using System.Windows.Forms;
using evoPhone.biz.Calls.Comparators;

namespace evoPhone.biz.Calls.ViewModel {
    public class CallsPresenter {
        private CallList vCallList;

        public CallsPresenter(CallList callList) {
            vCallList = callList;
        }

        public List<ListViewItem> GetCallsGrByDirection() {
            List<object[]> list = new List<object[]>();
            CallComparByContactAndDirect comparer = new CallComparByContactAndDirect();

            foreach (KeyValuePair<DateTime, Call> pair in vCallList) {
                Call call = pair.Value;
                object[] arr;
                bool found = false;

                foreach (object[] item in list) {
                    if (comparer.Compare((Call)item[0], call) == 0) {
                        found = true;
                        item[1] = (int)item[1] + 1;
                        break;
                    }
                }

                if (list.Count == 0 || !found) {
                    arr = new object[2];
                    arr[0] = call;
                    arr[1] = 1;
                    list.Add(arr);
                }
            }

            return ListToLVIList(list);
        }

        private List<ListViewItem> ListToLVIList(List<object[]> list) {
            List<ListViewItem> lviList = new List<ListViewItem>();
            foreach (object[] item in list) {
                Call call = (Call)item[0];
                int callsCount = (int)item[1];

                string[] arr = new string[4];
                arr[0] = call.Contact.Name;
                arr[1] = call.CallTime.ToString();
                arr[2] = call.CallDirection.ToString();
                arr[3] = callsCount.ToString();
                lviList.Add(new ListViewItem(arr));
            }

            return lviList;
        }
    }
}