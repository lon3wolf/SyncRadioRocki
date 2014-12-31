namespace TestApp
{
    partial class Form1
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
            this.Devices = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.selectedPlayers = new System.Windows.Forms.ListBox();
            this.mediaURL = new System.Windows.Forms.TextBox();
            this.Stop = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.volume = new System.Windows.Forms.TrackBar();
            this.VolLabel = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Channels = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Devices
            // 
            this.Devices.FormattingEnabled = true;
            this.Devices.Location = new System.Drawing.Point(117, 11);
            this.Devices.Name = "Devices";
            this.Devices.Size = new System.Drawing.Size(201, 24);
            this.Devices.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(11, 11);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(100, 35);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(179, 137);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 35);
            this.Play.TabIndex = 2;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(329, 11);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 35);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(153, 41);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(65, 35);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // selectedPlayers
            // 
            this.selectedPlayers.FormattingEnabled = true;
            this.selectedPlayers.ItemHeight = 16;
            this.selectedPlayers.Location = new System.Drawing.Point(27, 41);
            this.selectedPlayers.Name = "selectedPlayers";
            this.selectedPlayers.Size = new System.Drawing.Size(120, 132);
            this.selectedPlayers.TabIndex = 6;
            // 
            // mediaURL
            // 
            this.mediaURL.Location = new System.Drawing.Point(179, 109);
            this.mediaURL.Name = "mediaURL";
            this.mediaURL.Size = new System.Drawing.Size(275, 22);
            this.mediaURL.TabIndex = 7;
            this.mediaURL.Text = "http://67.213.213.143:8040";
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(260, 137);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 35);
            this.Stop.TabIndex = 8;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(341, 137);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(75, 35);
            this.Pause.TabIndex = 9;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // volume
            // 
            this.volume.Location = new System.Drawing.Point(467, 41);
            this.volume.Maximum = 100;
            this.volume.Name = "volume";
            this.volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volume.Size = new System.Drawing.Size(56, 104);
            this.volume.TabIndex = 10;
            this.volume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.volume.Value = 30;
            this.volume.ValueChanged += new System.EventHandler(this.volume_ValueChanged);
            this.volume.MouseUp += new System.Windows.Forms.MouseEventHandler(this.volume_MouseUp);
            // 
            // VolLabel
            // 
            this.VolLabel.AutoSize = true;
            this.VolLabel.Location = new System.Drawing.Point(453, 155);
            this.VolLabel.Name = "VolLabel";
            this.VolLabel.Size = new System.Drawing.Size(85, 17);
            this.VolLabel.TabIndex = 11;
            this.VolLabel.Text = "volume:  0%";
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(117, 36);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(201, 10);
            this.Status.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Status.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Channels);
            this.groupBox1.Controls.Add(this.Play);
            this.groupBox1.Controls.Add(this.mediaURL);
            this.groupBox1.Controls.Add(this.Clear);
            this.groupBox1.Controls.Add(this.selectedPlayers);
            this.groupBox1.Controls.Add(this.VolLabel);
            this.groupBox1.Controls.Add(this.Stop);
            this.groupBox1.Controls.Add(this.volume);
            this.groupBox1.Controls.Add(this.Pause);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 194);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Channels";
            // 
            // Channels
            // 
            this.Channels.FormattingEnabled = true;
            this.Channels.Location = new System.Drawing.Point(341, 21);
            this.Channels.Name = "Channels";
            this.Channels.Size = new System.Drawing.Size(201, 24);
            this.Channels.TabIndex = 12;
            this.Channels.SelectedValueChanged += new System.EventHandler(this.Channels_SelectedValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 265);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Devices);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(591, 312);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(591, 312);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "SyncRadio for Rocki";
            ((System.ComponentModel.ISupportInitialize)(this.volume)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Devices;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.ListBox selectedPlayers;
        private System.Windows.Forms.TextBox mediaURL;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.TrackBar volume;
        private System.Windows.Forms.Label VolLabel;
        private System.Windows.Forms.ProgressBar Status;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Channels;
    }
}

