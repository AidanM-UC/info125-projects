namespace SalePriceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal originalPrice;       // The item's original price
            decimal discountPercentage;  // The discount percentage
            decimal discountAmount;      // The amount of discount
            decimal salePrice;           // The item's sale price

            // Get the item's original price.
            originalPrice = decimal.Parse(textBox1.Text);

            // Get the discount percentage.

            // FILL IN HERE 
            // If you're unsure on how to get the discount percentage look at how the originalPrice is originated
            discountPercentage = decimal.Parse(discountPercentageTextBox.Text);

            // Move the percentage's decimal point left two spaces.
            discountPercentage = discountPercentage / 100;

            // Calculate the amount of the discount.

            // FILL IN HERE
            discountAmount = originalPrice * discountPercentage;

            // Calculate the sale price.

            // FILL IN HERE
            salePrice = originalPrice - discountAmount;

            // Display the sale price.
            salePriceLabel.Text = salePrice.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

   

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void discountPercentageTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}