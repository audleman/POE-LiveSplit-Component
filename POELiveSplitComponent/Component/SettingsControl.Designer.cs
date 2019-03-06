namespace POELiveSplitComponent.Component
{
    partial class SettingsControl
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GenerateSplits = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.checkAutoSplit = new System.Windows.Forms.CheckBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textLogLocation = new System.Windows.Forms.TextBox();
            this.autoSplitToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.loadRemovalToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.clientLocationToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GenerateSplits);
            this.groupBox1.Controls.Add(this.testButton);
            this.groupBox1.Controls.Add(this.checkAutoSplit);
            this.groupBox1.Controls.Add(this.browseButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textLogLocation);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto Split";
            // 
            // GenerateSplits
            // 
            this.GenerateSplits.Location = new System.Drawing.Point(12, 141);
            this.GenerateSplits.Name = "GenerateSplits";
            this.GenerateSplits.Size = new System.Drawing.Size(106, 23);
            this.GenerateSplits.TabIndex = 5;
            this.GenerateSplits.Text = "Generate Splits";
            this.GenerateSplits.UseVisualStyleBackColor = true;
            this.GenerateSplits.Click += new System.EventHandler(this.HandleGenerateSplits);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(12, 98);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 4;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.HandleTestClick);
            // 
            // checkAutoSplit
            // 
            this.checkAutoSplit.AutoSize = true;
            this.checkAutoSplit.Checked = true;
            this.checkAutoSplit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAutoSplit.Location = new System.Drawing.Point(12, 19);
            this.checkAutoSplit.Name = "checkAutoSplit";
            this.checkAutoSplit.Size = new System.Drawing.Size(124, 17);
            this.checkAutoSplit.TabIndex = 0;
            this.checkAutoSplit.Text = "Enable Auto Splitting";
            this.autoSplitToolTip.SetToolTip(this.checkAutoSplit, "Performs a split when the player enters a specific zone for the first time.");
            this.checkAutoSplit.UseVisualStyleBackColor = true;
            this.checkAutoSplit.CheckedChanged += new System.EventHandler(this.HandleAutoSplitChanged);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(284, 72);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 3;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.HandleBrowseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client log file location:";
            // 
            // textLogLocation
            // 
            this.textLogLocation.Location = new System.Drawing.Point(12, 72);
            this.textLogLocation.Name = "textLogLocation";
            this.textLogLocation.Size = new System.Drawing.Size(266, 20);
            this.textLogLocation.TabIndex = 2;
            this.clientLocationToolTip.SetToolTip(this.textLogLocation, "Used to detect load screen durations and zone locations.");
            this.textLogLocation.TextChanged += new System.EventHandler(this.handleLogLocationChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Text files|*.txt";
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(476, 266);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkAutoSplit;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox textLogLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip autoSplitToolTip;
        private System.Windows.Forms.ToolTip loadRemovalToolTip;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.ToolTip clientLocationToolTip;
        private System.Windows.Forms.Button GenerateSplits;
    }
}

