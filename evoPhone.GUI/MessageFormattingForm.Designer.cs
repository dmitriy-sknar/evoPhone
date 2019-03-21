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
            this.SuspendLayout();
            // 
            // SMSOutputBox
            // 
            this.SMSOutputBox.Location = new System.Drawing.Point(12, 39);
            this.SMSOutputBox.Name = "SMSOutputBox";
            this.SMSOutputBox.Size = new System.Drawing.Size(337, 437);
            this.SMSOutputBox.TabIndex = 0;
            this.SMSOutputBox.Text = "";
            // 
            // FormatingOptComboBox
            // 
            this.FormatingOptComboBox.FormattingEnabled = true;
            this.FormatingOptComboBox.Location = new System.Drawing.Point(12, 12);
            this.FormatingOptComboBox.Name = "FormatingOptComboBox";
            this.FormatingOptComboBox.Size = new System.Drawing.Size(167, 21);
            this.FormatingOptComboBox.TabIndex = 1;
            this.FormatingOptComboBox.Text = "Select Formatting";
            // 
            // SMSTimer
            // 
            this.SMSTimer.Enabled = true;
            this.SMSTimer.Interval = 2000;
            this.SMSTimer.Tick += new System.EventHandler(this.SMSTimer_Tick);
            // 
            // MessageFormattingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 488);
            this.Controls.Add(this.FormatingOptComboBox);
            this.Controls.Add(this.SMSOutputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MessageFormattingForm";
            this.Text = "Message Formatting";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox SMSOutputBox;
        private System.Windows.Forms.ComboBox FormatingOptComboBox;
        private System.Windows.Forms.Timer SMSTimer;
    }
}