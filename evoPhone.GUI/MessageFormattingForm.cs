using System;
using System.Collections.Generic;
using System.Windows.Forms;
using evoPhone.biz;
using evoPhone.biz.PhoneParts.SMS;
using EvoPhone.Common;
using Playback.Output;
using Message = evoPhone.biz.PhoneParts.SMS.Message;

namespace evoPhone.GUI {
    public partial class MessageFormattingForm : Form {
        private IOutput vOutputComponent;
        private Mobile vMobile;
        private SMSMessageFormatter vSmsMessageFormatter;
        private List<Message> vPreparedMessages;
        private List<ListViewItem> vListViewItems;

        public MessageFormattingForm() {
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

            //Output init 
            //vOutputComponent = new WinFormOutput(SMSOutputBox); //Lab3 solution
            vOutputComponent = new ListViewOutput(MessageListView); //Lab4 solution
            vMobile.SmsStorage.SMSStorageChangeHandler += OnSMSStorageChanged;
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

        private void UpdatePhoneNumberOptComboBox(List<Message> list) {
            foreach (var message in list) {
                if (!PhoneNumberOptComboBox.Items.Contains(message.Contact.Number)) {
                    int index = PhoneNumberOptComboBox.Items.Count == 0 ? 0 : PhoneNumberOptComboBox.Items.Count;
                    PhoneNumberOptComboBox.Items.Insert(index, message.Contact.Number);
                }
            }
        }

        private void OnSMSStorageChanged(object sender, EventArgs eventArgs) {
            UpdatePhoneNumberOptComboBox(vMobile.SmsStorage.List);
            UpdateOutput();
        }

        private void UpdateOutput() {
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
            vPreparedMessages = SMSMessageFilter.AllFilters(vMobile.SmsStorage.List, numberFilter, messageFilter, startDateTime, endDateTime);

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

        private void SMSTimer_Tick(object sender, EventArgs e) {
            //call is made directly to SMSProvider so far there is no logic about Message Receiving etc. It could be modified later.
            vMobile.SmsStorage.RaiseSMSReceivedEvent();
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
    }
}