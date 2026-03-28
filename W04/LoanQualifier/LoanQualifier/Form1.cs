namespace LoanQualifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Names constants
                // FILL IN BELOW 
                const decimal MINIMUM_SALARY = 40000;
                const int MINIMUM_YEARS_ON_JOB = 2;

                // Local variables
                decimal salary;
                int yearsOnJob;

                // Get the salary and years on the job.
                // FILL IN BELOW 
                salary = decimal.Parse(salaryTextBox.Text);
                yearsOnJob = int.Parse(yearsTextBox.Text);

                // Determine whether the user qualifies.
                // FILL IN THE FOLLOWING IF EXPRESSIONS AND THE OUTPUTS
                if (salary >= MINIMUM_SALARY)
                {
                    if (yearsOnJob >= MINIMUM_YEARS_ON_JOB)
                    {
                        // The user qualifies.
                        decisionLabel.Text = "You qualify for the load.";
                    }
                    else
                    {
                        // The user does not qualify.
                        decisionLabel.Text = "Minimum years at current " + "job not met.";
                    }
                }
                else
                {
                    // The user does not qualify.
                    decisionLabel.Text = "Minimum salary requirement " + "not met.";
                }
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and the decisionLabel.
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            // Reset the focus.
            salaryTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}