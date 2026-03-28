    namespace SalePriceCalculator
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
            discountPercentageTextBox = new TextBox();
            salePriceLabel = new Label();
            originalPricePromptLabel = new Label();
            outputDescriptionLabel = new Label();
            buttonCalculate = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // discountPercentageTextBox
            // 
            discountPercentageTextBox.Location = new Point(185, 48);
            discountPercentageTextBox.Name = "discountPercentageTextBox";
            discountPercentageTextBox.Size = new Size(100, 23);
            discountPercentageTextBox.TabIndex = 1;
            discountPercentageTextBox.TextChanged += discountPercentageTextBox_TextChanged;
            // 
            // salePriceLabel
            // 
            salePriceLabel.BorderStyle = BorderStyle.FixedSingle;
            salePriceLabel.Location = new Point(185, 80);
            salePriceLabel.Name = "salePriceLabel";
            salePriceLabel.Size = new Size(100, 23);
            salePriceLabel.TabIndex = 2;
            salePriceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // originalPricePromptLabel
            // 
            originalPricePromptLabel.AutoSize = true;
            originalPricePromptLabel.Location = new Point(13, 23);
            originalPricePromptLabel.Name = "originalPricePromptLabel";
            originalPricePromptLabel.Size = new Size(164, 15);
            originalPricePromptLabel.TabIndex = 3;
            originalPricePromptLabel.Text = "Enter the item's original price:";
            // 
            // outputDescriptionLabel
            // 
            outputDescriptionLabel.AutoSize = true;
            outputDescriptionLabel.Location = new Point(117, 84);
            outputDescriptionLabel.Name = "outputDescriptionLabel";
            outputDescriptionLabel.Size = new Size(60, 15);
            outputDescriptionLabel.TabIndex = 5;
            outputDescriptionLabel.Text = "Sale price:";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(68, 125);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(75, 43);
            buttonCalculate.TabIndex = 6;
            buttonCalculate.Text = "Calculate Sale Price";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += calculateButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(171, 125);
            button2.Name = "button2";
            button2.Size = new Size(75, 43);
            button2.TabIndex = 7;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 51);
            label1.Name = "label1";
            label1.Size = new Size(168, 15);
            label1.TabIndex = 8;
            label1.Text = "Enter the discount percentage:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 180);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(buttonCalculate);
            Controls.Add(outputDescriptionLabel);
            Controls.Add(originalPricePromptLabel);
            Controls.Add(salePriceLabel);
            Controls.Add(discountPercentageTextBox);
            Name = "Form1";
            Text = "Sale Price Calculator";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private TextBox discountPercentageTextBox;
        private Label salePriceLabel;
        private Label originalPricePromptLabel;
        private Label outputDescriptionLabel;
        private Button buttonCalculate;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
    }
}