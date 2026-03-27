namespace FriendFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare a StreamWriter variable.
                // FILL IN HERE
                StreamWriter outputFile;

                // Create a file and get a StreamWriter object
                // FILL IN HERE
                //outputFile = File.CreateText("friend.txt");
                outputFile = File.AppendText("Friend.txt");

                // Write the friend's name to the file;
                // FILL IN HERE
                outputFile.WriteLine(nameTextBox.Text);

                // Close the file
                // FILL IN HERE
                outputFile.Close();

                // Let the user know the name was written with a MessageBox 
                // FILL IN HERE
                MessageBox.Show("Name Stored");
                nameTextBox.Text = "";
                nameTextBox.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the application 
            // FILL IN HERE
            this.Close();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
