namespace LoanQualifier
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
            salaryPromptLabel = new Label();
            outputDescriptionLabel = new Label();
            checkButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            salaryTextBox = new TextBox();
            yearsTextBox = new TextBox();
            decisionLabel = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // salaryPromptLabel
            // 
            salaryPromptLabel.AutoSize = true;
            salaryPromptLabel.Location = new Point(73, 14);
            salaryPromptLabel.Name = "salaryPromptLabel";
            salaryPromptLabel.Size = new Size(81, 15);
            salaryPromptLabel.TabIndex = 0;
            salaryPromptLabel.Text = "Annual salary:";
            // 
            // outputDescriptionLabel
            // 
            outputDescriptionLabel.AutoSize = true;
            outputDescriptionLabel.Location = new Point(12, 71);
            outputDescriptionLabel.Name = "outputDescriptionLabel";
            outputDescriptionLabel.Size = new Size(83, 15);
            outputDescriptionLabel.TabIndex = 2;
            outputDescriptionLabel.Text = "Loan decision:";
            // 
            // checkButton
            // 
            checkButton.Location = new Point(12, 131);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(89, 40);
            checkButton.TabIndex = 6;
            checkButton.Text = "Check Qualifications";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(107, 131);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(89, 40);
            clearButton.TabIndex = 7;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(202, 131);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(89, 40);
            exitButton.TabIndex = 8;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // salaryTextBox
            // 
            salaryTextBox.Location = new Point(160, 11);
            salaryTextBox.Name = "salaryTextBox";
            salaryTextBox.Size = new Size(100, 23);
            salaryTextBox.TabIndex = 9;
            // 
            // yearsTextBox
            // 
            yearsTextBox.Location = new Point(160, 40);
            yearsTextBox.Name = "yearsTextBox";
            yearsTextBox.Size = new Size(100, 23);
            yearsTextBox.TabIndex = 10;
            // 
            // decisionLabel
            // 
            decisionLabel.BorderStyle = BorderStyle.FixedSingle;
            decisionLabel.Location = new Point(12, 86);
            decisionLabel.Name = "decisionLabel";
            decisionLabel.Size = new Size(248, 20);
            decisionLabel.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 43);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 12;
            label2.Text = "Years at current job:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 183);
            Controls.Add(label2);
            Controls.Add(decisionLabel);
            Controls.Add(yearsTextBox);
            Controls.Add(salaryTextBox);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(checkButton);
            Controls.Add(outputDescriptionLabel);
            Controls.Add(salaryPromptLabel);
            Name = "Form1";
            Text = "Loan Qualifier";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label salaryPromptLabel;
        private Label outputDescriptionLabel;
        private Button checkButton;
        private Button clearButton;
        private Button exitButton;
        private TextBox salaryTextBox;
        private TextBox yearsTextBox;
        private Label decisionLabel;
        private Label label2;
    }
}