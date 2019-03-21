using System;
using System.Windows.Forms;
using evoPhone.biz;
using evoPhone.biz.PhoneParts.Battery.Charger;
using evoPhone.biz.PhoneParts.Sound;
using EvoPhone.Common;
using EvoPhone.Common.Events;
using EvoPhone.Common.StringExtension;
using Playback.Output;

namespace evoPhone.GUI {
    public partial class MessageFormattingForm : Form {
        private IPlayback vPlaybackComponent;
        private ICharger vChargerComponent;
        private IOutput vOutputComponent;
        private Mobile vMobile;
        private SMSMessageFormatter vSmsMessageFormatter;

        public MessageFormattingForm() {
            InitializeComponent();
            vSmsMessageFormatter = new SMSMessageFormatter();
            InitFormattingOptComboBox();
            PhoneBuilder builder = new SimCorpPhoneBuilder();
            var phoneConstructor = new PhoneConstructor(builder);
            phoneConstructor.Construct();
            vMobile = builder.GetMobile;
            vMobile.SetAllActive();
            vOutputComponent = new WinFormOutput(SMSOutputBox);
            vMobile.SmsProvider.SMSReceivedHandler += OnSMSReceived;
        }

        private void InitFormattingOptComboBox() {
            var dictionary = vSmsMessageFormatter.GetFormattersDictionary();
            foreach (var keyValue in dictionary) {
                FormatingOptComboBox.Items.Insert(keyValue.Key, keyValue.Value);
            }
        }

        private void OnSMSReceived(object sender, SMSEventArgs eventArgs) {
            string message = eventArgs.SMS;
            int index = FormatingOptComboBox.SelectedIndex;
            var formatter = vSmsMessageFormatter.GetFormatter(index);
            string formattedMessage = formatter($"{message}");
            vOutputComponent.WriteLine(formattedMessage);
        }

        private void SMSTimer_Tick(object sender, EventArgs e) {
            //call is made directly to SMSProvider so far there is no logic about SMS Receiving etc. It could be modified later.
            vMobile.SmsProvider.RaiseSMSReceivedEvent();
        }
    }
}