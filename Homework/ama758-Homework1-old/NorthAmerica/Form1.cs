using System;

namespace NorthAmerica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            // Define filename
            string filePath;
            // Select the file
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Select Countries File";
            file.InitialDirectory = @"C:\\"; // Optional initial directory
            file.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"; // Filter file types


            try
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of the selected file
                    filePath = file.FileName;
                    // Use filePath to open and read the file
                    foreach (var line in File.ReadLines(filePath))
                    {
                        // Add each line to listbox
                        countriesListBox.Items.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the application
            this.Close();
        }

        private void saveCountryButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare a StreamWriter variable 

                // Open the NorthAmerica.txt file for appending 
                // and get a StreamWriter object.

                // Write the Countries name to the file 

                // Close the file

                // Let the user know what country was written 

                // Clear the countryTextBox control. 

                // Give the focus to the countryTextBox control.
            }
            catch (Exception ex)
            {
                // Display an Error Message
            }
        }

        private void addToListButton_Click(object sender, EventArgs e)
        {
            // Declare a variable to hold a country
            try
            {
                // Retrieve the text from the TextBox where the user enters a country

                // Add the retrieved country to the ListBox that displays the list of countries

                // Show a message box to inform the user that the country has been added
            }
            catch (Exception ex)
            {
                // Display an Error Message
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
