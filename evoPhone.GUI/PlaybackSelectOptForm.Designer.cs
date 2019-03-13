namespace evoPhone.GUI {
    partial class PlaybackSelectOptForm {
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
            this.PlayButton = new System.Windows.Forms.Button();
            this.MaxStereoHeadset = new System.Windows.Forms.RadioButton();
            this.BluetoothHeadset = new System.Windows.Forms.RadioButton();
            this.StereoHeadset = new System.Windows.Forms.RadioButton();
            this.Speaker = new System.Windows.Forms.RadioButton();
            this.LogTextBox = new System.Windows.Forms.RichTextBox();
            this.ChargeButton = new System.Windows.Forms.Button();
            this.PlayOptionsGroup = new System.Windows.Forms.GroupBox();
            this.ChargeOptionsGroup = new System.Windows.Forms.GroupBox();
            this.WirelessCharger = new System.Windows.Forms.RadioButton();
            this.StandardCharger = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PlayOptionsGroup.SuspendLayout();
            this.ChargeOptionsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(36, 131);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(100, 32);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // MaxStereoHeadset
            // 
            this.MaxStereoHeadset.AutoSize = true;
            this.MaxStereoHeadset.Checked = true;
            this.MaxStereoHeadset.Location = new System.Drawing.Point(24, 19);
            this.MaxStereoHeadset.Name = "MaxStereoHeadset";
            this.MaxStereoHeadset.Size = new System.Drawing.Size(122, 17);
            this.MaxStereoHeadset.TabIndex = 1;
            this.MaxStereoHeadset.TabStop = true;
            this.MaxStereoHeadset.Text = "Max Stereo Headset";
            this.MaxStereoHeadset.UseVisualStyleBackColor = true;
            // 
            // BluetoothHeadset
            // 
            this.BluetoothHeadset.AutoSize = true;
            this.BluetoothHeadset.Location = new System.Drawing.Point(24, 42);
            this.BluetoothHeadset.Name = "BluetoothHeadset";
            this.BluetoothHeadset.Size = new System.Drawing.Size(113, 17);
            this.BluetoothHeadset.TabIndex = 2;
            this.BluetoothHeadset.TabStop = true;
            this.BluetoothHeadset.Text = "Bluetooth Headset";
            this.BluetoothHeadset.UseVisualStyleBackColor = true;
            // 
            // StereoHeadset
            // 
            this.StereoHeadset.AutoSize = true;
            this.StereoHeadset.Location = new System.Drawing.Point(24, 65);
            this.StereoHeadset.Name = "StereoHeadset";
            this.StereoHeadset.Size = new System.Drawing.Size(99, 17);
            this.StereoHeadset.TabIndex = 3;
            this.StereoHeadset.TabStop = true;
            this.StereoHeadset.Text = "Stereo Headset";
            this.StereoHeadset.UseVisualStyleBackColor = true;
            // 
            // Speaker
            // 
            this.Speaker.AutoSize = true;
            this.Speaker.Location = new System.Drawing.Point(24, 88);
            this.Speaker.Name = "Speaker";
            this.Speaker.Size = new System.Drawing.Size(99, 17);
            this.Speaker.TabIndex = 4;
            this.Speaker.TabStop = true;
            this.Speaker.Text = "Phone Speaker";
            this.Speaker.UseVisualStyleBackColor = true;
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(12, 170);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(333, 129);
            this.LogTextBox.TabIndex = 5;
            this.LogTextBox.Text = "";
            // 
            // ChargeButton
            // 
            this.ChargeButton.Location = new System.Drawing.Point(205, 131);
            this.ChargeButton.Name = "ChargeButton";
            this.ChargeButton.Size = new System.Drawing.Size(100, 32);
            this.ChargeButton.TabIndex = 7;
            this.ChargeButton.Text = "Charge";
            this.ChargeButton.UseVisualStyleBackColor = true;
            this.ChargeButton.Click += new System.EventHandler(this.ChargeButton_Click);
            // 
            // PlayOptionsGroup
            // 
            this.PlayOptionsGroup.Controls.Add(this.Speaker);
            this.PlayOptionsGroup.Controls.Add(this.StereoHeadset);
            this.PlayOptionsGroup.Controls.Add(this.BluetoothHeadset);
            this.PlayOptionsGroup.Controls.Add(this.MaxStereoHeadset);
            this.PlayOptionsGroup.Location = new System.Drawing.Point(12, 12);
            this.PlayOptionsGroup.Name = "PlayOptionsGroup";
            this.PlayOptionsGroup.Size = new System.Drawing.Size(166, 113);
            this.PlayOptionsGroup.TabIndex = 9;
            this.PlayOptionsGroup.TabStop = false;
            this.PlayOptionsGroup.Text = "Select playback component:";
            // 
            // ChargeOptionsGroup
            // 
            this.ChargeOptionsGroup.Controls.Add(this.WirelessCharger);
            this.ChargeOptionsGroup.Controls.Add(this.StandardCharger);
            this.ChargeOptionsGroup.Location = new System.Drawing.Point(184, 12);
            this.ChargeOptionsGroup.Name = "ChargeOptionsGroup";
            this.ChargeOptionsGroup.Size = new System.Drawing.Size(161, 113);
            this.ChargeOptionsGroup.TabIndex = 10;
            this.ChargeOptionsGroup.TabStop = false;
            this.ChargeOptionsGroup.Text = "Select charge component:";
            // 
            // WirelessCharger
            // 
            this.WirelessCharger.AutoSize = true;
            this.WirelessCharger.Location = new System.Drawing.Point(21, 42);
            this.WirelessCharger.Name = "WirelessCharger";
            this.WirelessCharger.Size = new System.Drawing.Size(105, 17);
            this.WirelessCharger.TabIndex = 1;
            this.WirelessCharger.TabStop = true;
            this.WirelessCharger.Text = "Wireless Charger";
            this.WirelessCharger.UseVisualStyleBackColor = true;
            // 
            // StandardCharger
            // 
            this.StandardCharger.AutoSize = true;
            this.StandardCharger.Checked = true;
            this.StandardCharger.Location = new System.Drawing.Point(21, 19);
            this.StandardCharger.Name = "StandardCharger";
            this.StandardCharger.Size = new System.Drawing.Size(108, 17);
            this.StandardCharger.TabIndex = 0;
            this.StandardCharger.TabStop = true;
            this.StandardCharger.Text = "Standard Charger";
            this.StandardCharger.UseVisualStyleBackColor = true;
            // 
            // PlaybackSelectOptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 312);
            this.Controls.Add(this.ChargeOptionsGroup);
            this.Controls.Add(this.PlayOptionsGroup);
            this.Controls.Add(this.ChargeButton);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.PlayButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PlaybackSelectOptForm";
            this.Text = "Playback Select Options";
            this.PlayOptionsGroup.ResumeLayout(false);
            this.PlayOptionsGroup.PerformLayout();
            this.ChargeOptionsGroup.ResumeLayout(false);
            this.ChargeOptionsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.RadioButton MaxStereoHeadset;
        private System.Windows.Forms.RadioButton BluetoothHeadset;
        private System.Windows.Forms.RadioButton StereoHeadset;
        private System.Windows.Forms.RadioButton Speaker;
        private System.Windows.Forms.RichTextBox LogTextBox;
        private System.Windows.Forms.Button ChargeButton;
        private System.Windows.Forms.GroupBox PlayOptionsGroup;
        private System.Windows.Forms.GroupBox ChargeOptionsGroup;
        private System.Windows.Forms.RadioButton WirelessCharger;
        private System.Windows.Forms.RadioButton StandardCharger;
        private System.Windows.Forms.Timer timer1;
    }
}

