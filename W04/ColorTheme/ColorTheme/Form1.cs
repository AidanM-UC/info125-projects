namespace ColorTheme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (redRadioButton.Checked)
            {
                this.BackColor = Color.Red;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (whiteRadioButton.Checked)
            {
                this.BackColor = Color.White;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void yellowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (yellowRadioButton.Checked)
            {
                this.BackColor = Color.Yellow;
            }
        }

        private void normalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (normalRadioButton.Checked)
            {
                this.BackColor = Color.SlateGray;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
