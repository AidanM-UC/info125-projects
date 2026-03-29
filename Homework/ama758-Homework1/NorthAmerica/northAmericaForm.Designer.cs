namespace NorthAmerica
{
    partial class northAmericaForm
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
            countryTextBox = new TextBox();
            exitButton = new Button();
            addToListButton = new Button();
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
            enterCountryLabel.AutoSize = true;
            enterCountryLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enterCountryLabel.Location = new Point(486, 126);
            enterCountryLabel.Name = "enterCountryLabel";
            enterCountryLabel.Size = new Size(123, 20);
            enterCountryLabel.TabIndex = 4;
            enterCountryLabel.Text = "Enter a Country:";
            // 
            // saveCountryButton
            // 
            saveCountryButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveCountryButton.BackColor = SystemColors.ButtonFace;
            saveCountryButton.Font = new Font("Segoe UI", 11F);
            saveCountryButton.Location = new Point(486, 244);
            saveCountryButton.Name = "saveCountryButton";
            saveCountryButton.Size = new Size(123, 46);
            saveCountryButton.TabIndex = 6;
            saveCountryButton.Text = "Save to File";
            saveCountryButton.UseVisualStyleBackColor = false;
            saveCountryButton.Click += saveCountryButton_Click;
            // 
            // countriesListBox
            // 
            countriesListBox.BackColor = SystemColors.Info;
            countriesListBox.FormattingEnabled = true;
            countriesListBox.ItemHeight = 15;
            countriesListBox.Location = new Point(90, 77);
            countriesListBox.Name = "countriesListBox";
            countriesListBox.Size = new Size(328, 229);
            countriesListBox.TabIndex = 7;
            // 
            // countryTextBox
            // 
            countryTextBox.BackColor = SystemColors.Info;
            countryTextBox.Location = new Point(486, 163);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(123, 23);
            countryTextBox.TabIndex = 8;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            exitButton.BackColor = SystemColors.ButtonFace;
            exitButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitButton.Location = new Point(283, 336);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(110, 66);
            exitButton.TabIndex = 9;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // addToListButton
            // 
            addToListButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addToListButton.BackColor = SystemColors.ButtonFace;
            addToListButton.Font = new Font("Segoe UI", 11F);
            addToListButton.Location = new Point(486, 192);
            addToListButton.Name = "addToListButton";
            addToListButton.Size = new Size(123, 46);
            addToListButton.TabIndex = 10;
            addToListButton.Text = "Add to List";
            addToListButton.UseVisualStyleBackColor = false;
            addToListButton.Click += addToListButton_Click;
            // 
            // northAmericaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(687, 450);
            Controls.Add(addToListButton);
            Controls.Add(exitButton);
            Controls.Add(countryTextBox);
            Controls.Add(countriesListBox);
            Controls.Add(saveCountryButton);
            Controls.Add(enterCountryLabel);
            Controls.Add(getCountriesButton);
            Controls.Add(titleLabel);
            Name = "northAmericaForm";
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
        private TextBox countryTextBox;
        private Button exitButton;
        private Button addToListButton;
    }
}
