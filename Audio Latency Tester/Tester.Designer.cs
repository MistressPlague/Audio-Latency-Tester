namespace Audio_Latency_Tester
{
    partial class Tester
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tester));
            this.TestButton = new System.Windows.Forms.Button();
            this.PlaybackDevicesDropDown = new System.Windows.Forms.ComboBox();
            this.DropDownLabel = new System.Windows.Forms.Label();
            this.LatencyLabel = new System.Windows.Forms.Label();
            this.DropDownLabel2 = new System.Windows.Forms.Label();
            this.VACDevicesDropDown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TestButton
            // 
            this.TestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestButton.Location = new System.Drawing.Point(247, 8);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(75, 23);
            this.TestButton.TabIndex = 0;
            this.TestButton.Text = "Test!";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // PlaybackDevicesDropDown
            // 
            this.PlaybackDevicesDropDown.BackColor = System.Drawing.Color.Black;
            this.PlaybackDevicesDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlaybackDevicesDropDown.ForeColor = System.Drawing.Color.Magenta;
            this.PlaybackDevicesDropDown.FormattingEnabled = true;
            this.PlaybackDevicesDropDown.Location = new System.Drawing.Point(120, 10);
            this.PlaybackDevicesDropDown.Name = "PlaybackDevicesDropDown";
            this.PlaybackDevicesDropDown.Size = new System.Drawing.Size(121, 21);
            this.PlaybackDevicesDropDown.TabIndex = 1;
            this.PlaybackDevicesDropDown.SelectedIndexChanged += new System.EventHandler(this.PlaybackDevicesDropDown_SelectedIndexChanged);
            // 
            // DropDownLabel
            // 
            this.DropDownLabel.AutoSize = true;
            this.DropDownLabel.Location = new System.Drawing.Point(6, 13);
            this.DropDownLabel.Name = "DropDownLabel";
            this.DropDownLabel.Size = new System.Drawing.Size(91, 13);
            this.DropDownLabel.TabIndex = 2;
            this.DropDownLabel.Text = "Playback Device:";
            // 
            // LatencyLabel
            // 
            this.LatencyLabel.AutoSize = true;
            this.LatencyLabel.Location = new System.Drawing.Point(328, 13);
            this.LatencyLabel.Name = "LatencyLabel";
            this.LatencyLabel.Size = new System.Drawing.Size(51, 13);
            this.LatencyLabel.TabIndex = 3;
            this.LatencyLabel.Text = "Latency: ";
            // 
            // DropDownLabel2
            // 
            this.DropDownLabel2.AutoSize = true;
            this.DropDownLabel2.Location = new System.Drawing.Point(6, 40);
            this.DropDownLabel2.Name = "DropDownLabel2";
            this.DropDownLabel2.Size = new System.Drawing.Size(110, 13);
            this.DropDownLabel2.TabIndex = 5;
            this.DropDownLabel2.Text = "Optional VAC Device:";
            // 
            // VACDevicesDropDown
            // 
            this.VACDevicesDropDown.BackColor = System.Drawing.Color.Black;
            this.VACDevicesDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VACDevicesDropDown.ForeColor = System.Drawing.Color.Magenta;
            this.VACDevicesDropDown.FormattingEnabled = true;
            this.VACDevicesDropDown.Items.AddRange(new object[] {
            "None"});
            this.VACDevicesDropDown.Location = new System.Drawing.Point(120, 37);
            this.VACDevicesDropDown.Name = "VACDevicesDropDown";
            this.VACDevicesDropDown.Size = new System.Drawing.Size(121, 21);
            this.VACDevicesDropDown.TabIndex = 4;
            this.VACDevicesDropDown.SelectedIndexChanged += new System.EventHandler(this.VACDevicesDropDown_SelectedIndexChanged);
            // 
            // Tester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(418, 67);
            this.Controls.Add(this.DropDownLabel2);
            this.Controls.Add(this.VACDevicesDropDown);
            this.Controls.Add(this.LatencyLabel);
            this.Controls.Add(this.DropDownLabel);
            this.Controls.Add(this.PlaybackDevicesDropDown);
            this.Controls.Add(this.TestButton);
            this.ForeColor = System.Drawing.Color.Magenta;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Tester";
            this.Text = "Tester";
            this.Load += new System.EventHandler(this.Tester_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.ComboBox PlaybackDevicesDropDown;
        private System.Windows.Forms.Label DropDownLabel;
        private System.Windows.Forms.Label LatencyLabel;
        private System.Windows.Forms.Label DropDownLabel2;
        private System.Windows.Forms.ComboBox VACDevicesDropDown;
    }
}

