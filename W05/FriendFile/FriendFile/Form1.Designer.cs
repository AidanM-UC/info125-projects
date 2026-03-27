namespace FriendFile
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
            label1 = new Label();
            nameTextBox = new TextBox();
            writeNameButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(85, 62);
            label1.Name = "label1";
            label1.Size = new Size(198, 28);
            label1.TabIndex = 0;
            label1.Text = "Enter a friend's name:";
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Segoe UI", 15F);
            nameTextBox.Location = new Point(289, 62);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(183, 34);
            nameTextBox.TabIndex = 1;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // writeNameButton
            // 
            writeNameButton.Font = new Font("Segoe UI", 15F);
            writeNameButton.Location = new Point(113, 118);
            writeNameButton.Name = "writeNameButton";
            writeNameButton.Size = new Size(159, 38);
            writeNameButton.TabIndex = 2;
            writeNameButton.Text = "Write Name";
            writeNameButton.UseVisualStyleBackColor = true;
            writeNameButton.Click += writeNameButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 15F);
            exitButton.Location = new Point(313, 118);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(159, 38);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 187);
            Controls.Add(exitButton);
            Controls.Add(writeNameButton);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameTextBox;
        private Button writeNameButton;
        private Button exitButton;
    }
}
