namespace TimeZones
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cityListBox = new ListBox();
            promptLabel = new Label();
            okButton = new Button();
            outputDescriptionLabel = new Label();
            timeZoneLabel = new Label();
            exitButton = new Button();
            SuspendLayout();
            // 
            // cityListBox
            // 
            cityListBox.FormattingEnabled = true;
            cityListBox.ItemHeight = 15;
            cityListBox.Items.AddRange(new object[] { "Honolulu", "San Francisco", "Denver", "Minneapolis", "New York" });
            cityListBox.Location = new Point(73, 49);
            cityListBox.Name = "cityListBox";
            cityListBox.Size = new Size(120, 94);
            cityListBox.TabIndex = 0;
            cityListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // promptLabel
            // 
            promptLabel.AutoSize = true;
            promptLabel.Location = new Point(12, 20);
            promptLabel.Name = "promptLabel";
            promptLabel.Size = new Size(245, 15);
            promptLabel.TabIndex = 1;
            promptLabel.Text = "Select a city and I will give you the time zone.\r\n";
            promptLabel.Click += label1_Click;
            // 
            // okButton
            // 
            okButton.Location = new Point(47, 208);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 2;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // outputDescriptionLabel
            // 
            outputDescriptionLabel.AutoSize = true;
            outputDescriptionLabel.Location = new Point(47, 160);
            outputDescriptionLabel.Name = "outputDescriptionLabel";
            outputDescriptionLabel.Size = new Size(67, 15);
            outputDescriptionLabel.TabIndex = 3;
            outputDescriptionLabel.Text = "Time Zone:";
            // 
            // timeZoneLabel
            // 
            timeZoneLabel.BorderStyle = BorderStyle.FixedSingle;
            timeZoneLabel.Location = new Point(120, 159);
            timeZoneLabel.Name = "timeZoneLabel";
            timeZoneLabel.Size = new Size(94, 19);
            timeZoneLabel.TabIndex = 4;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(139, 208);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 5;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 261);
            Controls.Add(exitButton);
            Controls.Add(timeZoneLabel);
            Controls.Add(outputDescriptionLabel);
            Controls.Add(okButton);
            Controls.Add(promptLabel);
            Controls.Add(cityListBox);
            Name = "Form1";
            Text = "Time Zone";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox cityListBox;
        private Label promptLabel;
        private Button okButton;
        private Label outputDescriptionLabel;
        private Label timeZoneLabel;
        private Button exitButton;
    }
}
