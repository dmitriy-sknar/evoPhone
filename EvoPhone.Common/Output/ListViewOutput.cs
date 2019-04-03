using System.Collections.Generic;
using System.Windows.Forms;
using EvoPhone.Common;

namespace Playback.Output {
    public class ListViewOutput : IListViewOutput {
        private ListView vListView;
        public ListViewOutput(ListView listView) {
            vListView = listView;
        }
        public void Write(string text) {
            vListView.Items.Add(new ListViewItem(new string[3] { "", "", text }));
            vListView.Items[vListView.Items.Count - 1].EnsureVisible();
        }

        public void WriteLine(string text) {
            vListView.Items.Add(new ListViewItem(new string[3] {"","",text}));
            vListView.Items[vListView.Items.Count - 1].EnsureVisible();
        }

        public void WriteLines(List<ListViewItem> list) {
            vListView.Items.AddRange(list.ToArray());
            if(list.Count != 0) vListView.Items[list.Count - 1].EnsureVisible();
        }
    }
}


