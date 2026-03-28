namespace BirthDateString
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
            monthTextBox = new TextBox();
            yearTextBox = new TextBox();
            dayOfWeekPromptLabel = new Label();
            dayOfMonthPromptLabel = new Label();
            yearPromptLabel = new Label();
            clearButton = new Button();
            dayOfWeekTextBox = new TextBox();
            dayofMonthTextBox = new TextBox();
            monthPromptLabel = new Label();
            showDateButton = new Button();
            exitbutton = new Button();
            dateOutputLabel = new Label();
            SuspendLayout();
            // 
            // monthTextBox
            // 
            monthTextBox.Location = new Point(211, 43);
            monthTextBox.Name = "monthTextBox";
            monthTextBox.Size = new Size(100, 23);
            monthTextBox.TabIndex = 1;
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(211, 101);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(100, 23);
            yearTextBox.TabIndex = 3;
            // 
            // dayOfWeekPromptLabel
            // 
            dayOfWeekPromptLabel.AutoSize = true;
            dayOfWeekPromptLabel.Location = new Point(63, 18);
            dayOfWeekPromptLabel.Name = "dayOfWeekPromptLabel";
            dayOfWeekPromptLabel.Size = new Size(143, 15);
            dayOfWeekPromptLabel.TabIndex = 4;
            dayOfWeekPromptLabel.Text = "Enter the day of the week:";
            // 
            // dayOfMonthPromptLabel
            // 
            dayOfMonthPromptLabel.AutoSize = true;
            dayOfMonthPromptLabel.Location = new Point(7, 76);
            dayOfMonthPromptLabel.Name = "dayOfMonthPromptLabel";
            dayOfMonthPromptLabel.Size = new Size(199, 15);
            dayOfMonthPromptLabel.TabIndex = 6;
            dayOfMonthPromptLabel.Text = "Enter the numeric day of the month:";
            // 
            // yearPromptLabel
            // 
            yearPromptLabel.AutoSize = true;
            yearPromptLabel.Location = new Point(124, 105);
            yearPromptLabel.Name = "yearPromptLabel";
            yearPromptLabel.Size = new Size(82, 15);
            yearPromptLabel.TabIndex = 7;
            yearPromptLabel.Text = "Enter the year:";
            // 
            // clearButton
            // 
            clearButton.Location = new Point(125, 174);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 10;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // dayOfWeekTextBox
            // 
            dayOfWeekTextBox.Location = new Point(212, 14);
            dayOfWeekTextBox.Name = "dayOfWeekTextBox";
            dayOfWeekTextBox.Size = new Size(100, 23);
            dayOfWeekTextBox.TabIndex = 11;
            //dayOfWeekTextBox.TextChanged += dayOfWeekTextBox_TextChanged;
            // 
            // dayofMonthTextBox
            // 
            dayofMonthTextBox.Location = new Point(211, 72);
            dayofMonthTextBox.Name = "dayofMonthTextBox";
            dayofMonthTextBox.Size = new Size(100, 23);
            dayofMonthTextBox.TabIndex = 12;
            // 
            // monthPromptLabel
            // 
            monthPromptLabel.AutoSize = true;
            monthPromptLabel.Location = new Point(43, 46);
            monthPromptLabel.Name = "monthPromptLabel";
            monthPromptLabel.Size = new Size(163, 15);
            monthPromptLabel.TabIndex = 13;
            monthPromptLabel.Text = "Enter the name of the month:";
            //monthPromptLabel.Click += label1_Click;
            // 
            // showDateButton
            // 
            showDateButton.Location = new Point(43, 174);
            showDateButton.Name = "showDateButton";
            showDateButton.Size = new Size(75, 23);
            showDateButton.TabIndex = 14;
            showDateButton.Text = "Show Date";
            showDateButton.UseVisualStyleBackColor = true;
            showDateButton.Click += showDateButton_Click;
            // 
            // exitbutton
            // 
            exitbutton.Location = new Point(206, 174);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(75, 23);
            exitbutton.TabIndex = 15;
            exitbutton.Text = "Exit";
            exitbutton.UseVisualStyleBackColor = true;
            exitbutton.Click += exitButton_Click;
            // 
            // dateOutputLabel
            // 
            dateOutputLabel.BorderStyle = BorderStyle.FixedSingle;
            dateOutputLabel.Location = new Point(43, 142);
            dateOutputLabel.MinimumSize = new Size(10, 10);
            dateOutputLabel.Name = "dateOutputLabel";
            dateOutputLabel.Size = new Size(238, 16);
            dateOutputLabel.TabIndex = 16;
            dateOutputLabel.TextAlign = ContentAlignment.MiddleCenter;
            dateOutputLabel.Click += clearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 209);
            Controls.Add(dateOutputLabel);
            Controls.Add(exitbutton);
            Controls.Add(showDateButton);
            Controls.Add(monthPromptLabel);
            Controls.Add(dayofMonthTextBox);
            Controls.Add(dayOfWeekTextBox);
            Controls.Add(clearButton);
            Controls.Add(yearPromptLabel);
            Controls.Add(dayOfMonthPromptLabel);
            Controls.Add(dayOfWeekPromptLabel);
            Controls.Add(yearTextBox);
            Controls.Add(monthTextBox);
            Name = "Form1";
            Text = "Birth Date String";
            //Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private TextBox monthTextBox;
        private TextBox yearTextBox;
        private Label dayOfWeekPromptLabel;
        private Label dayOfMonthPromptLabel;
        private Label yearPromptLabel;
        private Button clearButton;
        private TextBox dayOfWeekTextBox;
        private TextBox dayofMonthTextBox;
        private Label monthPromptLabel;
        private Button showDateButton;
        private Button exitbutton;
        public Label dateOutputLabel;
    }
}