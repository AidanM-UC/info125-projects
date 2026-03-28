namespace NorthAmerica
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
            titleLabel = new Label();
            getCountriesButton = new Button();
            openFile = new OpenFileDialog();
            enterCountryLabel = new Label();
            saveCountryButton = new Button();
            countriesListBox = new ListBox();
            countryInput = new TextBox();
            addCountryButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(90, 44);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(328, 30);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "The Countries of North America";
            // 
            // getCountriesButton
            // 
            getCountriesButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            getCountriesButton.BackColor = SystemColors.ButtonFace;
            getCountriesButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            getCountriesButton.Location = new Point(116, 336);
            getCountriesButton.Name = "getCountriesButton";
            getCountriesButton.Size = new Size(110, 66);
            getCountriesButton.TabIndex = 2;
            getCountriesButton.Text = "Get Countries";
            getCountriesButton.UseVisualStyleBackColor = false;
            getCountriesButton.Click += getCountriesButton_Click;
            // 
            // enterCountryLabel
            // 
            enterCountryLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            enterCountryLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enterCountryLabel.Location = new Point(463, 140);
            enterCountryLabel.Name = "enterCountryLabel";
            enterCountryLabel.Size = new Size(157, 20);
            enterCountryLabel.TabIndex = 4;
            enterCountryLabel.Text = "Enter a Country:";
            enterCountryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // saveCountryButton
            // 
            saveCountryButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveCountryButton.BackColor = SystemColors.ButtonFace;
            saveCountryButton.Font = new Font("Segoe UI", 11F);
            saveCountryButton.Location = new Point(486, 244);
            saveCountryButton.Name = "saveCountryButton";
            saveCountryButton.Size = new Size(110, 46);
            saveCountryButton.TabIndex = 6;
            saveCountryButton.Text = "Save to File";
            saveCountryButton.UseVisualStyleBackColor = false;
            saveCountryButton.Click += saveCountryButton_Click;
            // 
            // countriesListBox
            // 
            countriesListBox.FormattingEnabled = true;
            countriesListBox.ItemHeight = 15;
            countriesListBox.Location = new Point(90, 99);
            countriesListBox.Name = "countriesListBox";
            countriesListBox.Size = new Size(316, 199);
            countriesListBox.TabIndex = 7;
            // 
            // countryInput
            // 
            countryInput.Location = new Point(486, 163);
            countryInput.Name = "countryInput";
            countryInput.Size = new Size(110, 23);
            countryInput.TabIndex = 8;
            countryInput.TextChanged += textBox1_TextChanged;
            // 
            // addCountryButton
            // 
            addCountryButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addCountryButton.BackColor = SystemColors.ButtonFace;
            addCountryButton.Font = new Font("Segoe UI", 11F);
            addCountryButton.Location = new Point(486, 192);
            addCountryButton.Name = "addCountryButton";
            addCountryButton.Size = new Size(110, 46);
            addCountryButton.TabIndex = 9;
            addCountryButton.Text = "Add to List";
            addCountryButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            exitButton.BackColor = SystemColors.ButtonFace;
            exitButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitButton.Location = new Point(267, 336);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(110, 66);
            exitButton.TabIndex = 10;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(687, 450);
            Controls.Add(exitButton);
            Controls.Add(addCountryButton);
            Controls.Add(countryInput);
            Controls.Add(countriesListBox);
            Controls.Add(saveCountryButton);
            Controls.Add(enterCountryLabel);
            Controls.Add(getCountriesButton);
            Controls.Add(titleLabel);
            Name = "Form1";
            Text = "North America";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Button getCountriesButton;
        private OpenFileDialog openFile;
        private Label enterCountryLabel;
        private Button saveCountryButton;
        private ListBox countriesListBox;
        private TextBox countryInput;
        private Button addCountryButton;
        private Button exitButton;
    }
}
