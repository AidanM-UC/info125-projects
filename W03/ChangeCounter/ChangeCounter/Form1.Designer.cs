namespace ChangeCounter
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
            instructionLabel = new Label();
            fiveCentsPictureBox = new PictureBox();
            tenCentsPictureBox = new PictureBox();
            twentyFiveCentsPictureBox = new PictureBox();
            fiftyCentsPictureBox = new PictureBox();
            outputDescriptionLabel = new Label();
            totalLabel = new Label();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)fiveCentsPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tenCentsPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)twentyFiveCentsPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fiftyCentsPictureBox).BeginInit();
            SuspendLayout();
            // 
            // instructionLabel
            // 
            instructionLabel.AutoSize = true;
            instructionLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            instructionLabel.Location = new Point(156, 9);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(99, 17);
            instructionLabel.TabIndex = 0;
            instructionLabel.Text = "Click the Coins";
            // 
            // fiveCentsPictureBox
            // 
            fiveCentsPictureBox.Image = Properties.Resources._5cents;
            fiveCentsPictureBox.Location = new Point(12, 37);
            fiveCentsPictureBox.Name = "fiveCentsPictureBox";
            fiveCentsPictureBox.Size = new Size(125, 181);
            fiveCentsPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            fiveCentsPictureBox.TabIndex = 1;
            fiveCentsPictureBox.TabStop = false;
            fiveCentsPictureBox.Click += fiveCentsPictureBox_Click;
            // 
            // tenCentsPictureBox
            // 
            tenCentsPictureBox.Image = Properties.Resources._10cents;
            tenCentsPictureBox.Location = new Point(156, 37);
            tenCentsPictureBox.Name = "tenCentsPictureBox";
            tenCentsPictureBox.Size = new Size(125, 181);
            tenCentsPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            tenCentsPictureBox.TabIndex = 2;
            tenCentsPictureBox.TabStop = false;
            tenCentsPictureBox.Click += tenCentsPictureBox_Click;
            // 
            // twentyFiveCentsPictureBox
            // 
            twentyFiveCentsPictureBox.Image = Properties.Resources._25cents;
            twentyFiveCentsPictureBox.Location = new Point(12, 224);
            twentyFiveCentsPictureBox.Name = "twentyFiveCentsPictureBox";
            twentyFiveCentsPictureBox.Size = new Size(125, 181);
            twentyFiveCentsPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            twentyFiveCentsPictureBox.TabIndex = 3;
            twentyFiveCentsPictureBox.TabStop = false;
            twentyFiveCentsPictureBox.Click += twentyFiveCentsPictureBox_Click;
            // 
            // fiftyCentsPictureBox
            // 
            fiftyCentsPictureBox.Image = Properties.Resources._50cents;
            fiftyCentsPictureBox.Location = new Point(156, 224);
            fiftyCentsPictureBox.Name = "fiftyCentsPictureBox";
            fiftyCentsPictureBox.Size = new Size(125, 181);
            fiftyCentsPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            fiftyCentsPictureBox.TabIndex = 4;
            fiftyCentsPictureBox.TabStop = false;
            fiftyCentsPictureBox.Click += fiftyCentsPictureBox_Click;
            // 
            // outputDescriptionLabel
            // 
            outputDescriptionLabel.AutoSize = true;
            outputDescriptionLabel.Location = new Point(332, 179);
            outputDescriptionLabel.Name = "outputDescriptionLabel";
            outputDescriptionLabel.Size = new Size(35, 15);
            outputDescriptionLabel.TabIndex = 5;
            outputDescriptionLabel.Text = "Total:";
            outputDescriptionLabel.Click += label1_Click;
            // 
            // totalLabel
            // 
            totalLabel.BorderStyle = BorderStyle.FixedSingle;
            totalLabel.Location = new Point(314, 194);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(70, 15);
            totalLabel.TabIndex = 6;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(170, 420);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 7;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 455);
            Controls.Add(exitButton);
            Controls.Add(totalLabel);
            Controls.Add(outputDescriptionLabel);
            Controls.Add(fiftyCentsPictureBox);
            Controls.Add(twentyFiveCentsPictureBox);
            Controls.Add(tenCentsPictureBox);
            Controls.Add(fiveCentsPictureBox);
            Controls.Add(instructionLabel);
            Name = "Form1";
            Text = "Change Counter";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)fiveCentsPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)tenCentsPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)twentyFiveCentsPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)fiftyCentsPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label instructionLabel;
        private PictureBox fiveCentsPictureBox;
        private PictureBox tenCentsPictureBox;
        private PictureBox twentyFiveCentsPictureBox;
        private PictureBox fiftyCentsPictureBox;
        private Label outputDescriptionLabel;
        private Label totalLabel;
        private Button exitButton;
    }
}