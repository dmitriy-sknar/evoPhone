using System;
using System.Collections.Generic;
using System.Windows.Forms;
using evoPhone.biz;
using evoPhone.biz.Calls.Events;
using evoPhone.biz.PhoneParts.TasksAndThreads;
using EvoPhone.Common;
using Playback.Output;
using evoPhone.biz.Calls.ViewModel;

namespace evoPhone.GUI {
    public partial class CallHistoryForm : Form {
        private IOutput vOutputComponent;
        private Mobile vMobile;
        private List<ListViewItem> vListViewItems;
        private CallGenerationThread vCallGenerationThread;
        private bool IsCallGenerationRunning = false;

        public CallHistoryForm() {
            InitializeComponent();
            InitializeListView();

            //Phone init stage
            PhoneBuilder builder = new SimCorpPhoneBuilder();
            var phoneConstructor = new PhoneConstructor(builder);
            phoneConstructor.Construct();
            vMobile = builder.GetMobile;
            vMobile.SetAllActive();

            //Initialization is continued in OnLoad
        }

        private void OnCallListChanged(object sender, CallEventArgs eventArgs) {
            if (!this.IsDisposed)
                if (InvokeRequired)
                    Invoke(new Action(UpdateOutput));
                 else
                    UpdateOutput();
        }

        private void UpdateOutput() {
            vListViewItems.Clear();
            CallsPresenter callsPresenter = new CallsPresenter(vMobile.CallStorage.GetCallList());
            vListViewItems = callsPresenter.GetCallsGrByDirection();

            CallsListView.Items.Clear();
            ((IListViewOutput)vOutputComponent).WriteLines(vListViewItems);
        }

        private void InitializeListView() {
            vListViewItems = new List<ListViewItem>();
        }

        private void EnableCallsBtn_Click(object sender, EventArgs e) {
            if (IsCallGenerationRunning) {
                vCallGenerationThread.Stop();
                EnableCallsBtn.Text = "Enable Calls";
                IsCallGenerationRunning = false;
            } else {
                vCallGenerationThread.Start();
                EnableCallsBtn.Text = "Disable Calls";
                IsCallGenerationRunning = true;
            }
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            vOutputComponent = new ListViewOutput(CallsListView);
            vMobile.CallStorage.CallReceivedHandler += OnCallListChanged;
            vCallGenerationThread = new CallGenerationThread(vMobile);
        }
    }
}