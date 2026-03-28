namespace PayrollWithOvertime
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
            hoursWorkedPromptLabel = new Label();
            hourlyPayRatePromptLabel = new Label();
            outputDescriptionLabel = new Label();
            grossPayLabel = new Label();
            hoursWorkedTextBox = new TextBox();
            hourlyPayRateTextBox = new TextBox();
            calculateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // hoursWorkedPromptLabel
            // 
            hoursWorkedPromptLabel.AutoSize = true;
            hoursWorkedPromptLabel.Location = new Point(36, 14);
            hoursWorkedPromptLabel.Name = "hoursWorkedPromptLabel";
            hoursWorkedPromptLabel.Size = new Size(84, 15);
            hoursWorkedPromptLabel.TabIndex = 0;
            hoursWorkedPromptLabel.Text = "Hours worked:";
            // 
            // hourlyPayRatePromptLabel
            // 
            hourlyPayRatePromptLabel.AutoSize = true;
            hourlyPayRatePromptLabel.Location = new Point(29, 42);
            hourlyPayRatePromptLabel.Name = "hourlyPayRatePromptLabel";
            hourlyPayRatePromptLabel.Size = new Size(91, 15);
            hourlyPayRatePromptLabel.TabIndex = 1;
            hourlyPayRatePromptLabel.Text = "Hourly pay rate:";
            // 
            // outputDescriptionLabel
            // 
            outputDescriptionLabel.AutoSize = true;
            outputDescriptionLabel.Location = new Point(59, 68);
            outputDescriptionLabel.Name = "outputDescriptionLabel";
            outputDescriptionLabel.Size = new Size(61, 15);
            outputDescriptionLabel.TabIndex = 2;
            outputDescriptionLabel.Text = "Gross pay:";
            // 
            // grossPayLabel
            // 
            grossPayLabel.BorderStyle = BorderStyle.FixedSingle;
            grossPayLabel.Location = new Point(126, 64);
            grossPayLabel.Name = "grossPayLabel";
            grossPayLabel.Size = new Size(100, 23);
            grossPayLabel.TabIndex = 3;
            grossPayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hoursWorkedTextBox
            // 
            hoursWorkedTextBox.Location = new Point(126, 10);
            hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            hoursWorkedTextBox.Size = new Size(100, 23);
            hoursWorkedTextBox.TabIndex = 4;
            // 
            // hourlyPayRateTextBox
            // 
            hourlyPayRateTextBox.Location = new Point(126, 37);
            hourlyPayRateTextBox.Name = "hourlyPayRateTextBox";
            hourlyPayRateTextBox.Size = new Size(100, 23);
            hourlyPayRateTextBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(21, 104);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(67, 44);
            calculateButton.TabIndex = 6;
            calculateButton.Text = "Calculate Gross Pay";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(94, 104);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(67, 44);
            clearButton.TabIndex = 7;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(167, 104);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(67, 44);
            exitButton.TabIndex = 8;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 160);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(calculateButton);
            Controls.Add(hourlyPayRateTextBox);
            Controls.Add(hoursWorkedTextBox);
            Controls.Add(grossPayLabel);
            Controls.Add(outputDescriptionLabel);
            Controls.Add(hourlyPayRatePromptLabel);
            Controls.Add(hoursWorkedPromptLabel);
            Name = "Form1";
            Text = "Payroll With Overtime";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label hoursWorkedPromptLabel;
        private Label hourlyPayRatePromptLabel;
        private Label outputDescriptionLabel;
        private Label grossPayLabel;
        private TextBox hoursWorkedTextBox;
        private TextBox hourlyPayRateTextBox;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
    }
}