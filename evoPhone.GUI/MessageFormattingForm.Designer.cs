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
            this.FormatingOptComboBox.Location = new System.Drawing.Point(12, 38);
            this.FormatingOptComboBox.Name = "FormatingOptComboBox";
            this.FormatingOptComboBox.Size = new System.Drawing.Size(167, 21);
            this.FormatingOptComboBox.TabIndex = 1;
            this.FormatingOptComboBox.Text = "Select Formatting";
            this.FormatingOptComboBox.SelectedIndexChanged += new System.EventHandler(this.FormatingOptComboBox_SelectedIndexChanged);
            // 
            // SMSTimer
            // 
            this.SMSTimer.Enabled = true;
            this.SMSTimer.Interval = 5000;
            this.SMSTimer.Tick += new System.EventHandler(this.SMSTimer_Tick);
            // 
            // PhoneNumberOptComboBox
            // 
            this.PhoneNumberOptComboBox.FormattingEnabled = true;
            this.PhoneNumberOptComboBox.Location = new System.Drawing.Point(365, 12);
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
            this.DateFrom.Location = new System.Drawing.Point(365, 39);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Size = new System.Drawing.Size(130, 20);
            this.DateFrom.TabIndex = 3;
            this.DateFrom.ValueChanged += new System.EventHandler(this.DateFrom_ValueChanged);
            // 
            // DateTo
            // 
            this.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTo.Location = new System.Drawing.Point(501, 39);
            this.DateTo.Name = "DateTo";
            this.DateTo.Size = new System.Drawing.Size(130, 20);
            this.DateTo.TabIndex = 4;
            this.DateTo.ValueChanged += new System.EventHandler(this.DateTo_ValueChanged);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(501, 13);
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
            this.MessageListView.Location = new System.Drawing.Point(10, 65);
            this.MessageListView.Name = "MessageListView";
            this.MessageListView.Size = new System.Drawing.Size(620, 480);
            this.MessageListView.TabIndex = 6;
            this.MessageListView.UseCompatibleStateImageBehavior = false;
            this.MessageListView.View = System.Windows.Forms.View.Details;
            // 
            // ContactNumber
            // 
            this.ContactNumber.Text = "Contact Number";
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
            // MessageFormattingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 557);
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
    }
}