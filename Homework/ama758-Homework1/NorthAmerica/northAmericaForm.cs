using System.Diagnostics.Metrics;

namespace NorthAmerica
{
    public partial class northAmericaForm : Form
    {
        public northAmericaForm()
        {
            InitializeComponent();
        }

        // The GetFileName method gets a filename from the 
        // user and assigns it to the variable passed as
        // an argument.
        private static string GetFileName(string fileName)
        {
            try
            {
                var openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                openFileDialog.Title = "Select a Text File Containing Country Names";
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.DefaultExt = "txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return fileName;
        }

        // The GetCountries method accepts a file name as an 
        // argument. It opens the specified file and displays
        // its contents in the countriesListBox control.
        private void getCountries(string fileName)
        {
            try
            {
                foreach (var line in File.ReadLines(fileName))
                {
                    // Add each line to listbox
                    countriesListBox.Items.Add(line);
                }
                // Declare a variable to hold a country name
                string countryName;

                // Declare a StreamReader Variable
                StreamReader sr;

                // Open the file and get a StreamReader object
                sr = new StreamReader(fileName);

                // Clear anything currently in the ListBox.
                countriesListBox.Items.Clear();

                // Read the file's contents.
                string content = sr.ReadToEnd();

                string[] countries = content.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

                int index = 0;
                while (index < countries.Length)
                {
                    // Get a Country name.
                    countryName = countries[index++];

                    // Add the country name to the ListBox
                    if (countryName.Length > 0)
                    {
                        countriesListBox.Items.Add(countryName);
                    }
                }


                // Close the file.
                sr.Close();
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            // Declare a variable To hold the filename
            string fileName = "";

            // Get the filename from the user.
            fileName = GetFileName(fileName);

            // Get the countries from the file.
            getCountries(fileName);
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
                StreamWriter sr;

                string country = countryTextBox.Text;
                string? path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

                // Open the NorthAmerica.txt file for appending 
                // and get a StreamWriter object.
                sr = new StreamWriter(path + "/NorthAmerica.txt", true);

                // Write the Countries name to the file
                sr.WriteLine(country);

                // Close the file
                sr.Close();

                // Let the user know what country was written 
                MessageBox.Show(country + " has been appended to the file \"NorthAmerica.txt\".");

                // Clear the countryTextBox control.
                countryTextBox.Text = "";

                // Give the focus to the countryTextBox control.
                countryTextBox.Focus();
            }
            catch (Exception ex)
            {
                // Display an Error Message
                MessageBox.Show(ex.Message);
            }
        }

        private void addToListButton_Click(object sender, EventArgs e)
        {
            // Declare a variable to hold a country
            string country;

            try
            {
                // Retrieve the text from the TextBox where the user enters a country
                country = countryTextBox.Text;

                if (country.Trim().Length > 0 && country.Trim() == country)
                {
                    // Add the retrieved country to the ListBox that displays the list of countries
                    countriesListBox.Items.Add(country);

                    // Show a message box to inform the user that the country has been added
                    MessageBox.Show(country + " has been added to the list.");
                }
                else
                {
                    MessageBox.Show("\"" + country + "\" is an invalid name.");
                }
            }
            catch (Exception ex)
            {
                // Display an Error Message
                MessageBox.Show(ex.Message);
            }
        }
    }
}
