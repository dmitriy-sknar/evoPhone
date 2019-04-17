namespace evoPhone.GUI {
    partial class MessageFormattingForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.SMSOutputBox = new System.Windows.Forms.RichTextBox();
            this.FormatingOptComboBox = new System.Windows.Forms.ComboBox();
            this.SMSTimer = new System.Windows.Forms.Timer(this.components);
            this.PhoneNumberOptComboBox = new System.Windows.Forms.ComboBox();
            this.DateFrom = new System.Windows.Forms.DateTimePicker();
            this.DateTo = new System.Windows.Forms.DateTimePicker();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.MessageListView = new System.Windows.Forms.ListView();
            this.ContactNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContactName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SMSMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEnableMessaging = new System.Windows.Forms.Button();
            this.btnDisableMessaging = new System.Windows.Forms.Button();
            this.btnCharge = new System.Windows.Forms.Button();
            this.barChargeLevel = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // SMSOutputBox
            // 
            this.SMSOutputBox.Location = new System.Drawing.Point(12, 117);
            this.SMSOutputBox.Name = "SMSOutputBox";
            this.SMSOutputBox.Size = new System.Drawing.Size(406, 88);
            this.SMSOutputBox.TabIndex = 0;
            this.SMSOutputBox.Text = "";
            // 
            // FormatingOptComboBox
            // 
            this.FormatingOptComboBox.FormattingEnabled = true;
            this.FormatingOptComboBox.Location = new System.Drawing.Point(501, 12);
            this.FormatingOptComboBox.Name = "FormatingOptComboBox";
            this.FormatingOptComboBox.Size = new System.Drawing.Size(129, 21);
            this.FormatingOptComboBox.TabIndex = 1;
            this.FormatingOptComboBox.Text = "Select Formatting";
            this.FormatingOptComboBox.SelectedIndexChanged += new System.EventHandler(this.FormatingOptComboBox_SelectedIndexChanged);
            // 
            // PhoneNumberOptComboBox
            // 
            this.PhoneNumberOptComboBox.FormattingEnabled = true;
            this.PhoneNumberOptComboBox.Location = new System.Drawing.Point(363, 38);
            this.PhoneNumberOptComboBox.Name = "PhoneNumberOptComboBox";
            this.PhoneNumberOptComboBox.Size = new System.Drawing.Size(130, 21);
            this.PhoneNumberOptComboBox.TabIndex = 2;
            this.PhoneNumberOptComboBox.Text = "Filter by phone number";
            this.PhoneNumberOptComboBox.SelectedIndexChanged += new System.EventHandler(this.PhoneNumberOptComboBox_SelectedIndexChanged);
            this.PhoneNumberOptComboBox.Leave += new System.EventHandler(this.PhoneNumberOptComboBox_Leave);
            // 
            // DateFrom
            // 
            this.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFrom.Location = new System.Drawing.Point(363, 65);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Size = new System.Drawing.Size(130, 20);
            this.DateFrom.TabIndex = 3;
            this.DateFrom.ValueChanged += new System.EventHandler(this.DateFrom_ValueChanged);
            // 
            // DateTo
            // 
            this.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTo.Location = new System.Drawing.Point(499, 65);
            this.DateTo.Name = "DateTo";
            this.DateTo.Size = new System.Drawing.Size(130, 20);
            this.DateTo.TabIndex = 4;
            this.DateTo.ValueChanged += new System.EventHandler(this.DateTo_ValueChanged);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(499, 39);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(130, 20);
            this.SearchBox.TabIndex = 5;
            this.SearchBox.Text = "Search";
            this.SearchBox.Click += new System.EventHandler(this.SearchBox_Click);
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            this.SearchBox.Leave += new System.EventHandler(this.SearchBox_Leave);
            // 
            // MessageListView
            // 
            this.MessageListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ContactNumber,
            this.ContactName,
            this.SMSMessage});
            this.MessageListView.GridLines = true;
            this.MessageListView.Location = new System.Drawing.Point(10, 94);
            this.MessageListView.Name = "MessageListView";
            this.MessageListView.Size = new System.Drawing.Size(620, 509);
            this.MessageListView.TabIndex = 6;
            this.MessageListView.UseCompatibleStateImageBehavior = false;
            this.MessageListView.View = System.Windows.Forms.View.Details;
            // 
            // ContactNumber
            // 
            this.ContactNumber.Text = "Contact MainNumber";
            this.ContactNumber.Width = 110;
            // 
            // ContactName
            // 
            this.ContactName.Text = "Contact Name";
            this.ContactName.Width = 150;
            // 
            // SMSMessage
            // 
            this.SMSMessage.Text = "SMS Message";
            this.SMSMessage.Width = 360;
            // 
            // btnEnableMessaging
            // 
            this.btnEnableMessaging.Location = new System.Drawing.Point(12, 38);
            this.btnEnableMessaging.Name = "btnEnableMessaging";
            this.btnEnableMessaging.Size = new System.Drawing.Size(130, 23);
            this.btnEnableMessaging.TabIndex = 7;
            this.btnEnableMessaging.Text = "Enable messaging";
            this.btnEnableMessaging.UseVisualStyleBackColor = true;
            this.btnEnableMessaging.Click += new System.EventHandler(this.btnEnableMessaging_Click);
            // 
            // btnDisableMessaging
            // 
            this.btnDisableMessaging.Enabled = false;
            this.btnDisableMessaging.Location = new System.Drawing.Point(12, 62);
            this.btnDisableMessaging.Name = "btnDisableMessaging";
            this.btnDisableMessaging.Size = new System.Drawing.Size(130, 23);
            this.btnDisableMessaging.TabIndex = 8;
            this.btnDisableMessaging.Text = "Disable messaging";
            this.btnDisableMessaging.UseVisualStyleBackColor = true;
            this.btnDisableMessaging.Click += new System.EventHandler(this.btnDisableMessaging_Click);
            // 
            // btnCharge
            // 
            this.btnCharge.Location = new System.Drawing.Point(216, 12);
            this.btnCharge.Name = "btnCharge";
            this.btnCharge.Size = new System.Drawing.Size(127, 23);
            this.btnCharge.TabIndex = 9;
            this.btnCharge.Text = "Connect charger";
            this.btnCharge.UseVisualStyleBackColor = true;
            this.btnCharge.Click += new System.EventHandler(this.btnCharge_Click);
            // 
            // barChargeLevel
            // 
            this.barChargeLevel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.barChargeLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.barChargeLevel.Location = new System.Drawing.Point(10, 12);
            this.barChargeLevel.Name = "barChargeLevel";
            this.barChargeLevel.Size = new System.Drawing.Size(200, 23);
            this.barChargeLevel.Step = 1;
            this.barChargeLevel.TabIndex = 10;
            this.barChargeLevel.Value = 100;
            // 
            // MessageFormattingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 615);
            this.Controls.Add(this.barChargeLevel);
            this.Controls.Add(this.btnCharge);
            this.Controls.Add(this.btnDisableMessaging);
            this.Controls.Add(this.btnEnableMessaging);
            this.Controls.Add(this.MessageListView);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.DateTo);
            this.Controls.Add(this.DateFrom);
            this.Controls.Add(this.PhoneNumberOptComboBox);
            this.Controls.Add(this.FormatingOptComboBox);
            this.Controls.Add(this.SMSOutputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MessageFormattingForm";
            this.Text = "Message Formatting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox SMSOutputBox;
        private System.Windows.Forms.ComboBox FormatingOptComboBox;
        private System.Windows.Forms.Timer SMSTimer;
        private System.Windows.Forms.ComboBox PhoneNumberOptComboBox;
        private System.Windows.Forms.DateTimePicker DateFrom;
        private System.Windows.Forms.DateTimePicker DateTo;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.ListView MessageListView;
        private System.Windows.Forms.ColumnHeader ContactNumber;
        private System.Windows.Forms.ColumnHeader ContactName;
        private System.Windows.Forms.ColumnHeader SMSMessage;
        private System.Windows.Forms.Button btnEnableMessaging;
        private System.Windows.Forms.Button btnDisableMessaging;
        private System.Windows.Forms.Button btnCharge;
        private System.Windows.Forms.ProgressBar barChargeLevel;
    }
}