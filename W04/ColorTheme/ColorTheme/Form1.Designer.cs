namespace ColorTheme
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
            groupBox1 = new GroupBox();
            whiteRadioButton = new RadioButton();
            normalRadioButton = new RadioButton();
            redRadioButton = new RadioButton();
            yellowRadioButton = new RadioButton();
            exitButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(whiteRadioButton);
            groupBox1.Controls.Add(normalRadioButton);
            groupBox1.Controls.Add(redRadioButton);
            groupBox1.Controls.Add(yellowRadioButton);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(183, 153);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select a Background Color";
            // 
            // whiteRadioButton
            // 
            whiteRadioButton.AutoSize = true;
            whiteRadioButton.Location = new Point(51, 22);
            whiteRadioButton.Name = "whiteRadioButton";
            whiteRadioButton.Size = new Size(56, 19);
            whiteRadioButton.TabIndex = 4;
            whiteRadioButton.TabStop = true;
            whiteRadioButton.Text = "White";
            whiteRadioButton.UseVisualStyleBackColor = true;
            whiteRadioButton.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // normalRadioButton
            // 
            normalRadioButton.AutoSize = true;
            normalRadioButton.Location = new Point(51, 72);
            normalRadioButton.Name = "normalRadioButton";
            normalRadioButton.Size = new Size(65, 19);
            normalRadioButton.TabIndex = 3;
            normalRadioButton.TabStop = true;
            normalRadioButton.Text = "Normal";
            normalRadioButton.UseVisualStyleBackColor = true;
            normalRadioButton.CheckedChanged += normalRadioButton_CheckedChanged;
            // 
            // redRadioButton
            // 
            redRadioButton.AutoSize = true;
            redRadioButton.Location = new Point(51, 97);
            redRadioButton.Name = "redRadioButton";
            redRadioButton.Size = new Size(45, 19);
            redRadioButton.TabIndex = 2;
            redRadioButton.TabStop = true;
            redRadioButton.Text = "Red";
            redRadioButton.UseVisualStyleBackColor = true;
            redRadioButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // yellowRadioButton
            // 
            yellowRadioButton.AutoSize = true;
            yellowRadioButton.Location = new Point(51, 47);
            yellowRadioButton.Name = "yellowRadioButton";
            yellowRadioButton.Size = new Size(59, 19);
            yellowRadioButton.TabIndex = 0;
            yellowRadioButton.TabStop = true;
            yellowRadioButton.Text = "Yellow";
            yellowRadioButton.UseVisualStyleBackColor = true;
            yellowRadioButton.CheckedChanged += yellowRadioButton_CheckedChanged;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(53, 171);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(98, 23);
            exitButton.TabIndex = 1;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(207, 207);
            Controls.Add(groupBox1);
            Controls.Add(exitButton);
            Name = "Form1";
            Text = "Color Theme";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button exitButton;
        private RadioButton yellowRadioButton;
        private RadioButton whiteRadioButton;
        private RadioButton normalRadioButton;
        private RadioButton redRadioButton;
    }
}
