namespace evoPhone.GUI {
    partial class CallHistoryForm {
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
            this.CallsListView = new System.Windows.Forms.ListView();
            this.EnableCallsBtn = new System.Windows.Forms.Button();
            this.Contact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Direction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumberOfCalls = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // CallsListView
            // 
            this.CallsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Contact,
            this.Time,
            this.Direction,
            this.NumberOfCalls});
            this.CallsListView.Location = new System.Drawing.Point(12, 41);
            this.CallsListView.Name = "CallsListView";
            this.CallsListView.Size = new System.Drawing.Size(760, 534);
            this.CallsListView.TabIndex = 0;
            this.CallsListView.UseCompatibleStateImageBehavior = false;
            // 
            // EnableCallsBtn
            // 
            this.EnableCallsBtn.Location = new System.Drawing.Point(650, 12);
            this.EnableCallsBtn.Name = "EnableCallsBtn";
            this.EnableCallsBtn.Size = new System.Drawing.Size(122, 23);
            this.EnableCallsBtn.TabIndex = 1;
            this.EnableCallsBtn.Text = "Enable Calls";
            this.EnableCallsBtn.UseVisualStyleBackColor = true;
            this.EnableCallsBtn.Click += new System.EventHandler(this.EnableCallsBtn_Click);
            // 
            // Contact
            // 
            this.Contact.Text = "Contact";
            this.Contact.Width = 100;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 80;
            // 
            // Direction
            // 
            this.Direction.Text = "Direction";
            // 
            // NumberOfCalls
            // 
            this.NumberOfCalls.Text = "Number of calls";
            this.NumberOfCalls.Width = 20;
            // 
            // CallHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 587);
            this.Controls.Add(this.EnableCallsBtn);
            this.Controls.Add(this.CallsListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "CallHistoryForm";
            this.Text = "CallHistoryForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView CallsListView;
        private System.Windows.Forms.Button EnableCallsBtn;
        private System.Windows.Forms.ColumnHeader Contact;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Direction;
        private System.Windows.Forms.ColumnHeader NumberOfCalls;
    }
}