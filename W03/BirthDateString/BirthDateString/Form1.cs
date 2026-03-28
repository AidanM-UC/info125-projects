namespace BirthDateString
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            // Declare a string variable.
            string output;

            // Concatenate the input and build the output string.
            output = dayOfWeekTextBox.Text + ", " +
                monthTextBox.Text + ", " +
                dayofMonthTextBox.Text + ", " +
                yearTextBox.Text;
            // Fill this in here with the dayOfMonthTextBox.Text and yearTextBox.Text to correctly format the Output
            // The lines above are extracing the data from the text box and adding it with " "            


            // Display the output string in the dateOutputLabel control.
            dateOutputLabel.Text = output;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes.
            dayOfWeekTextBox.Text = "";
            monthTextBox.Text = "";
            dayofMonthTextBox.Text = "";
            yearTextBox.Text = "";

            // Fill in here to clear the dayOfMonthTextBox
            // Fill in here to clear the yearTextBox
            // If you get stuck look at the above lines which are clearing the dayOfWeekTextBox


            // Clear the dateOutputLabel control.
            dateOutputLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}