namespace Flags
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
            finlandPictureBox = new PictureBox();
            francePictureBox = new PictureBox();
            germanyPictureBox = new PictureBox();
            instructionLabel = new Label();
            countryLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)finlandPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)francePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)germanyPictureBox).BeginInit();
            SuspendLayout();
            // 
            // finlandPictureBox
            // 
            finlandPictureBox.BorderStyle = BorderStyle.FixedSingle;
            finlandPictureBox.Image = Properties.Resources.Finland;
            finlandPictureBox.Location = new Point(12, 45);
            finlandPictureBox.Name = "finlandPictureBox";
            finlandPictureBox.Size = new Size(122, 72);
            finlandPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            finlandPictureBox.TabIndex = 0;
            finlandPictureBox.TabStop = false;
            finlandPictureBox.Click += finlandPictureBox_Click;
            // 
            // francePictureBox
            // 
            francePictureBox.BorderStyle = BorderStyle.FixedSingle;
            francePictureBox.Image = Properties.Resources.France;
            francePictureBox.Location = new Point(149, 45);
            francePictureBox.Name = "francePictureBox";
            francePictureBox.Size = new Size(122, 72);
            francePictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            francePictureBox.TabIndex = 1;
            francePictureBox.TabStop = false;
            francePictureBox.Click += francePictureBox_Click;
            // 
            // germanyPictureBox
            // 
            germanyPictureBox.BorderStyle = BorderStyle.FixedSingle;
            germanyPictureBox.Image = Properties.Resources.Germany;
            germanyPictureBox.Location = new Point(287, 45);
            germanyPictureBox.Name = "germanyPictureBox";
            germanyPictureBox.Size = new Size(122, 72);
            germanyPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            germanyPictureBox.TabIndex = 2;
            germanyPictureBox.TabStop = false;
            germanyPictureBox.Click += germanyPictureBox_Click;
            // 
            // instructionLabel
            // 
            instructionLabel.AutoSize = true;
            instructionLabel.Location = new Point(100, 9);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(233, 15);
            instructionLabel.TabIndex = 3;
            instructionLabel.Text = "Click a flag to see the name of the country.";
            // 
            // countryLabel
            // 
            countryLabel.BorderStyle = BorderStyle.FixedSingle;
            countryLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            countryLabel.Location = new Point(77, 131);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(279, 23);
            countryLabel.TabIndex = 4;
            countryLabel.TextAlign = ContentAlignment.MiddleCenter;
            countryLabel.Click += countryLabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 168);
            Controls.Add(countryLabel);
            Controls.Add(instructionLabel);
            Controls.Add(germanyPictureBox);
            Controls.Add(francePictureBox);
            Controls.Add(finlandPictureBox);
            Name = "Form1";
            Text = "Flags";
            ((System.ComponentModel.ISupportInitialize)finlandPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)francePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)germanyPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private PictureBox finlandPictureBox;
        private PictureBox francePictureBox;
        private PictureBox germanyPictureBox;
        private Label instructionLabel;
        private Label countryLabel;
    }
}