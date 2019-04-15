using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using evoPhone.biz;
using evoPhone.biz.PhoneParts.Battery.Charger;
using evoPhone.biz.PhoneParts.Battery.Charger.Factory;
using evoPhone.biz.PhoneParts.SMS;
using evoPhone.biz.PhoneParts.TasksAndThreads;
using EvoPhone.Common;
using EvoPhone.Common.DateTime;
using Playback.Output;
using Message = evoPhone.biz.PhoneParts.SMS.Message;

namespace evoPhone.GUI {
    public partial class MessageFormattingForm : Form {
        private IOutput vOutputComponent;
        private Mobile vMobile;
        private SMSMessageFormatter vSmsMessageFormatter;
        private List<Message> vPreparedMessages;
        private List<ListViewItem> vListViewItems;
        private SMSGenerationThread vSMSGenerationThread;

        public MessageFormattingForm() {
            Application.EnableVisualStyles();

            //Form init stage
            InitializeComponent();
            InitializeListView();
            vSmsMessageFormatter = new SMSMessageFormatter();
            InitFormattingOptComboBox();
            DateFrom.Value = DateTime.Today;
            DateTo.Value = DateTime.Today.AddDays(1);

            //Phone init stage
            PhoneBuilder builder = new SimCorpPhoneBuilder();
            var phoneConstructor = new PhoneConstructor(builder);
            phoneConstructor.Construct();
            vMobile = builder.GetMobile;
            vMobile.SetAllActive();

            //Initialization is continued in OnLoad
        }

        private void InitializeListView() {
            vListViewItems = new List<ListViewItem>();
        }

        private void InitFormattingOptComboBox() {
            var dictionary = vSmsMessageFormatter.GetFormattersDictionary();
            foreach (var keyValue in dictionary) {
                FormatingOptComboBox.Items.Insert(keyValue.Key, keyValue.Value);
            }
        }

        private void UpdatePhoneNumberOptComboBox() {
            List<Message> list = vMobile.SmsStorage.List;
            foreach (var message in list) {
                if (!PhoneNumberOptComboBox.Items.Contains(message.Contact.Number)) {
                    int index = PhoneNumberOptComboBox.Items.Count == 0 ? 0 : PhoneNumberOptComboBox.Items.Count;
                    PhoneNumberOptComboBox.Items.Insert(index, message.Contact.Number);
                }
            }
        }

        private void OnSMSStorageChanged(object sender, EventArgs eventArgs) {
            if (InvokeRequired) Invoke(new Action(UpdateOutput));
            else UpdateOutput();
        }

        private void UpdateOutput() {
            UpdatePhoneNumberOptComboBox();
            // prepare formatter
            int index = FormatingOptComboBox.SelectedIndex;
            var formatter = vSmsMessageFormatter.GetFormatter(index);

            //prepare filters
            long numberFilter = 0;
            if (PhoneNumberOptComboBox.SelectedIndex != -1) {
                string selectedNumber = PhoneNumberOptComboBox.Items[PhoneNumberOptComboBox.SelectedIndex].ToString();
                numberFilter = long.Parse(selectedNumber, System.Globalization.NumberStyles.Number);
            }
            string messageFilter = SearchBox.Text;
            DateTime startDateTime = DateFrom.Value;
            DateTime endDateTime = DateTo.Value;

            //prepare message list
            vPreparedMessages = SMSMessageFilter.AllFilters(vMobile.SmsStorage.List, numberFilter, messageFilter,
                startDateTime, endDateTime);

            vListViewItems.Clear();
            foreach (var message in vPreparedMessages) {
                string[] arr = new string[3];
                arr[0] = message.Contact.Number.ToString();
                arr[1] = message.Contact.Name;
                arr[2] = formatter(message);
                vListViewItems.Add(new ListViewItem(arr));
            }
            MessageListView.Items.Clear();
            ((IListViewOutput) vOutputComponent).WriteLines(vListViewItems);
        }

        private void SearchBox_Click(object sender, EventArgs e) {
            if (SearchBox.Text.Equals("Search"))
                SearchBox.Text = "";
        }

        private void SearchBox_Leave(object sender, EventArgs e) {
            if (SearchBox.Text.Equals("")) SearchBox.Text = "Search";
        }

        private void PhoneNumberOptComboBox_Leave(object sender, EventArgs e) {
            if (PhoneNumberOptComboBox.Text.Equals("")) {
                PhoneNumberOptComboBox.Text = "Filter by phone number";
                PhoneNumberOptComboBox.SelectedIndex = -1;
            }
        }

        private void FormatingOptComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (vPreparedMessages != null)
                UpdateOutput();
        }

        private void PhoneNumberOptComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (vPreparedMessages != null)
                UpdateOutput();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e) {
            if (vPreparedMessages != null)
                UpdateOutput();
        }

        private void DateFrom_ValueChanged(object sender, EventArgs e) {
            if (vPreparedMessages != null)
                UpdateOutput();
        }

        private void DateTo_ValueChanged(object sender, EventArgs e) {
            if (vPreparedMessages != null)
                UpdateOutput();
        }

        private void btnCharge_Click(object sender, EventArgs e) {
            if (vMobile.ChargerComponent.IsReachableConnected) {
                vMobile.ChargerComponent.IsReachableConnected = false;
                btnCharge.Text = "Connect charger";
            }
            else {
                vMobile.ChargerComponent.IsReachableConnected = true;
                btnCharge.Text = "Disconnect charger";
            }
        }

        private void btnEnableMessaging_Click(object sender, EventArgs e) {
            vSMSGenerationThread.Start();
            btnEnableMessaging.Enabled = false;
            btnDisableMessaging.Enabled = true;
        }

        private void btnDisableMessaging_Click(object sender, EventArgs e) {
            vSMSGenerationThread.Stop();
            btnEnableMessaging.Enabled = true;
            btnDisableMessaging.Enabled = false;
        }

        private void OnBatteryChargeLevelChanged(object sender, EventArgs eventArgs) {
            if (InvokeRequired)
                Invoke(new Action(UpdateChargeLevelBar));
            else
                UpdateChargeLevelBar();
        }

        private void UpdateChargeLevelBar() {
            if (vMobile.ChargerComponent.IsReachableConnected) barChargeLevel.SetState(1);
            else barChargeLevel.SetState(2);

            barChargeLevel.Value = vMobile.Battery.ChargeLevel;
        }


        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            //Output init 
            //Lab3 solution
            //vOutputComponent = new WinFormOutput(SMSOutputBox);

            //Lab4 solution
            vOutputComponent = new ListViewOutput(MessageListView);
            vMobile.SmsStorage.SMSStorageChangeHandler += OnSMSStorageChanged;
            vSMSGenerationThread = new SMSGenerationThread(vMobile);

            barChargeLevel.SetState(1);

            // Initialization of Charger and it's threads/tasks

            //Thread-based charger
            //ChargerCreator chargerCreator = new ThreadChargerCreator();

            //Task-based charger
            ChargerCreator chargerCreator = new TaskChargerCreator();
            IInteractiveCharger charger = chargerCreator.CreateCharger(vMobile.Battery, TimeUnits.Second(), TimeUnits.TwoSeconds());
            charger.ChargeLevelChangedHandler += OnBatteryChargeLevelChanged;
            vMobile.ChargerComponent = charger;
        }
    }

    public static class ModifyProgressBarColor {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);

        public static void SetState(this ProgressBar pBar, int state) {
            if (!pBar.IsDisposed)
                SendMessage(pBar.Handle, 1040, (IntPtr) state, IntPtr.Zero);
        }
    }
}