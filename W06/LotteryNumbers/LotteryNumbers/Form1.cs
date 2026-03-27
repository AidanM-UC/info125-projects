namespace LotteryNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void generateButton_Click(object sender, EventArgs e)
        {
            // Initialise a constant integer variable named SIZE that equals 5
            // FILL IN HERE
            const int SIZE = 5;

            // Create an array named lotteryNumbers to hold the numbers. 
            // FILL IN HERE
            int[] lotteryNumbers = new int[SIZE];

            // Creates a Random object 
            var rand = new Random();

            // Fill the array with random numbers in the range
            // of 0 through 99
            // FILL IN the FOR loop conditions 
            for (int index = 0; index < lotteryNumbers.Length; index++)
            {
                // Sets the lotteryNumbers[index] to a random integer 
                //FILL IN HERE
                lotteryNumbers[index] = rand.Next(99);
            }

            // Display the array elements in the Label controls. 
            // FILL IN HERE to ensure all 5 lables are displaying the random integers
            firstLabel.Text = lotteryNumbers[0].ToString();
            secondLabel.Text = lotteryNumbers[1].ToString();
            thirdLabel.Text = lotteryNumbers[2].ToString();
            fourthLabel.Text = lotteryNumbers[3].ToString();
            fifthLabel.Text = lotteryNumbers[4].ToString();


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Closes the application 
            // FILL IN HERE
            this.Close();
            
        }
    }
}
