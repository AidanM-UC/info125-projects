namespace LotteryNumbers
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
            generateButton = new Button();
            exitButton = new Button();
            firstLabel = new Label();
            secondLabel = new Label();
            thirdLabel = new Label();
            fourthLabel = new Label();
            fifthLabel = new Label();
            SuspendLayout();
            // 
            // generateButton
            // 
            generateButton.BackColor = SystemColors.ActiveBorder;
            generateButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            generateButton.Location = new Point(122, 117);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(89, 53);
            generateButton.TabIndex = 5;
            generateButton.Text = "Generate Numbers";
            generateButton.UseVisualStyleBackColor = false;
            generateButton.Click += generateButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = SystemColors.ActiveBorder;
            exitButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitButton.Location = new Point(300, 117);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(89, 53);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // firstLabel
            // 
            firstLabel.BorderStyle = BorderStyle.Fixed3D;
            firstLabel.Location = new Point(33, 19);
            firstLabel.Name = "firstLabel";
            firstLabel.Size = new Size(83, 53);
            firstLabel.TabIndex = 7;
            firstLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // secondLabel
            // 
            secondLabel.BorderStyle = BorderStyle.Fixed3D;
            secondLabel.Location = new Point(122, 19);
            secondLabel.Name = "secondLabel";
            secondLabel.Size = new Size(83, 53);
            secondLabel.TabIndex = 8;
            secondLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // thirdLabel
            // 
            thirdLabel.BorderStyle = BorderStyle.Fixed3D;
            thirdLabel.Location = new Point(211, 19);
            thirdLabel.Name = "thirdLabel";
            thirdLabel.Size = new Size(83, 53);
            thirdLabel.TabIndex = 9;
            thirdLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fourthLabel
            // 
            fourthLabel.BorderStyle = BorderStyle.Fixed3D;
            fourthLabel.Location = new Point(300, 19);
            fourthLabel.Name = "fourthLabel";
            fourthLabel.Size = new Size(83, 53);
            fourthLabel.TabIndex = 10;
            fourthLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fifthLabel
            // 
            fifthLabel.BorderStyle = BorderStyle.Fixed3D;
            fifthLabel.Location = new Point(389, 19);
            fifthLabel.Name = "fifthLabel";
            fifthLabel.Size = new Size(83, 53);
            fifthLabel.TabIndex = 11;
            fifthLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 205);
            Controls.Add(fifthLabel);
            Controls.Add(fourthLabel);
            Controls.Add(thirdLabel);
            Controls.Add(secondLabel);
            Controls.Add(firstLabel);
            Controls.Add(exitButton);
            Controls.Add(generateButton);
            Name = "Form1";
            Text = "Lottery Numbers";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button generateButton;
        private Button exitButton;
        private Label firstLabel;
        private Label secondLabel;
        private Label thirdLabel;
        private Label fourthLabel;
        private Label fifthLabel;
    }
}
