namespace AverageRaceTimes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.runner1TextBox = new System.Windows.Forms.TextBox();
            this.runner2TextBox = new System.Windows.Forms.TextBox();
            this.runner3TextBox = new System.Windows.Forms.TextBox();
            this.runner1Label = new System.Windows.Forms.Label();
            this.runner2Label = new System.Windows.Forms.Label();
            this.runner3Label = new System.Windows.Forms.Label();
            this.averageTimeLabel = new System.Windows.Forms.Label();
            this.descriptorAverageLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.descriptorAverageLabel);
            this.panel1.Controls.Add(this.averageTimeLabel);
            this.panel1.Controls.Add(this.runner3Label);
            this.panel1.Controls.Add(this.runner2Label);
            this.panel1.Controls.Add(this.runner1Label);
            this.panel1.Controls.Add(this.runner3TextBox);
            this.panel1.Controls.Add(this.runner2TextBox);
            this.panel1.Controls.Add(this.runner1TextBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 152);
            this.panel1.TabIndex = 0;
            // 
            // runner1TextBox
            // 
            this.runner1TextBox.Location = new System.Drawing.Point(138, 18);
            this.runner1TextBox.Name = "runner1TextBox";
            this.runner1TextBox.Size = new System.Drawing.Size(100, 23);
            this.runner1TextBox.TabIndex = 1;
            // 
            // runner2TextBox
            // 
            this.runner2TextBox.Location = new System.Drawing.Point(138, 47);
            this.runner2TextBox.Name = "runner2TextBox";
            this.runner2TextBox.Size = new System.Drawing.Size(100, 23);
            this.runner2TextBox.TabIndex = 2;
            // 
            // runner3TextBox
            // 
            this.runner3TextBox.Location = new System.Drawing.Point(138, 76);
            this.runner3TextBox.Name = "runner3TextBox";
            this.runner3TextBox.Size = new System.Drawing.Size(100, 23);
            this.runner3TextBox.TabIndex = 3;
            // 
            // runner1Label
            // 
            this.runner1Label.AutoSize = true;
            this.runner1Label.Location = new System.Drawing.Point(75, 21);
            this.runner1Label.Name = "runner1Label";
            this.runner1Label.Size = new System.Drawing.Size(57, 15);
            this.runner1Label.TabIndex = 4;
            this.runner1Label.Text = "Runner 1:";
            // 
            // runner2Label
            // 
            this.runner2Label.AutoSize = true;
            this.runner2Label.Location = new System.Drawing.Point(75, 50);
            this.runner2Label.Name = "runner2Label";
            this.runner2Label.Size = new System.Drawing.Size(57, 15);
            this.runner2Label.TabIndex = 5;
            this.runner2Label.Text = "Runner 2:";
            // 
            // runner3Label
            // 
            this.runner3Label.AutoSize = true;
            this.runner3Label.Location = new System.Drawing.Point(75, 79);
            this.runner3Label.Name = "runner3Label";
            this.runner3Label.Size = new System.Drawing.Size(57, 15);
            this.runner3Label.TabIndex = 6;
            this.runner3Label.Text = "Runner 3:";
            // 
            // averageTimeLabel
            // 
            this.averageTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageTimeLabel.Location = new System.Drawing.Point(138, 112);
            this.averageTimeLabel.Name = "averageTimeLabel";
            this.averageTimeLabel.Size = new System.Drawing.Size(100, 23);
            this.averageTimeLabel.TabIndex = 7;
            this.averageTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptorAverageLabel
            // 
            this.descriptorAverageLabel.AutoSize = true;
            this.descriptorAverageLabel.Location = new System.Drawing.Point(22, 116);
            this.descriptorAverageLabel.Name = "descriptorAverageLabel";
            this.descriptorAverageLabel.Size = new System.Drawing.Size(110, 15);
            this.descriptorAverageLabel.TabIndex = 8;
            this.descriptorAverageLabel.Text = "Average Race Time:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(21, 180);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 40);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Calculate Average";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(102, 180);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 40);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(184, 180);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 40);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 237);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Average Race Times";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label descriptorAverageLabel;
        private Label averageTimeLabel;
        private Label runner3Label;
        private Label runner2Label;
        private Label runner1Label;
        private TextBox runner3TextBox;
        private TextBox runner2TextBox;
        private TextBox runner1TextBox;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
    }
}