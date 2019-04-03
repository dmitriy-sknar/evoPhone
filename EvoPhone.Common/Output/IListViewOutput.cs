using System.Collections.Generic;
using System.Windows.Forms;

namespace EvoPhone.Common {
    public interface IListViewOutput : IOutput {
        void WriteLines(List<ListViewItem> list);
    }
}