namespace SwornStudyList
{
    public partial class SwornStudyListForm : Form
    {
        string currentFileName = "";

        public SwornStudyListForm()
        {
            InitializeComponent();
        }

        /*
        Event handlers for the form's controls to be implemented:

        theListBox_SelectedIndexChanged
        loadListButton_Click
        saveListButton_Click
        addToListButton_Click
        updateItemButton_Click
        removeItemButton_Click

        */

        private void swornStudyList_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult result = MessageBox.Show(
            //    "Would you want go back and save any changes before closing?", "Hodld the Door!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (result == DialogResult.Yes)
            //{
            //    e.Cancel = true;
            //}
            //else if (result == DialogResult.No)
            //{
            //    ;
            //}
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            string item = itemTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(item))
            {
                theListBox.Items.Add(item);
            }

        }

        private void theListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = theListBox.SelectedIndex;

            if (selectedIndex > -1)
            {

                itemTextBox.Text = theListBox.Items[selectedIndex].ToString();
                //MessageBox.Show(itemTextBox.Text);
            }
        }

        private static string getFileName(string fileName)
        {
            var openFileDialog = new OpenFileDialog();

            //openFileDialog.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            //openFileDialog.Title = "Select a Text File Containing Country Names";
            //openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            //openFileDialog.DefaultExt = "txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
            }
            else
            {
                fileName = "null";
                MessageBox.Show("File not found");
            }

            return fileName;
        }

        private void loadListButton_Click(object sender, EventArgs e)
        {
            string fileName = "";
            fileName = getFileName(fileName);

            theListBox.Items.Clear();
            theListBox.Items.AddRange(File.ReadAllLines(fileName));

        }

        private void saveListButton_Click(object sender, EventArgs e)
        {
            string fileName = "";
            fileName = getFileName(fileName);
            //List[] l = theListBox.Items;
            File.WriteAllLines(fileName, theListBox.Items.Cast<string>());
        }

        private void updateItemButton_Click(object sender, EventArgs e)
        {
            string item = itemTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(item))
            {
                theListBox.Items[theListBox.SelectedIndex] = item;
            }
        }
    }
}
