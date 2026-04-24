namespace SwornStudyList
{
    public partial class SwornStudyListForm : Form
    {
        string currentFileName = "";

        public SwornStudyListForm()
        {
            InitializeComponent();
        }

        private void theListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (theListBox.SelectedIndex != -1)
            {
                itemTextBox.Text = theListBox.Items[theListBox.SelectedIndex].ToString();
            }
        }

        private void loadListButton_Click(object sender, EventArgs e)
        {
            if (openListDialog.ShowDialog() == DialogResult.OK)
            {
                currentFileName = openListDialog.FileName;

                string[] lines = File.ReadAllLines(currentFileName);

                theListBox.Items.Clear();

                foreach (string line in lines)
                {
                    theListBox.Items.Add(line);
                }
            }
        }

        private void saveListButton_Click(object sender, EventArgs e)
        {
            if (saveListDialog.ShowDialog() == DialogResult.OK)
            {
                currentFileName = saveListDialog.FileName;

                string[] lines = new string[theListBox.Items.Count];

                for (int i = 0; i < theListBox.Items.Count; i++)
                {
                    lines[i] = theListBox.Items[i].ToString();
                }

                File.WriteAllLines(currentFileName, lines);
                MessageBox.Show("Sworn study list saved to:\n" + currentFileName, "Mellon!");
            }
        }

        private void addToListButton_Click(object sender, EventArgs e)
        {
            string item;
            item = itemTextBox.Text.Trim();
            if (item == "")
            {
                MessageBox.Show("Please type in the item you are swearing by first.", "What's the Item Again?");
                return;
            }
            theListBox.Items.Add(item);
            itemTextBox.Clear();
            itemTextBox.Focus();
        }

        private void updateItemButton_Click(object sender, EventArgs e)
        {
            if (theListBox.Items.Count == 0)
            {
                MessageBox.Show("The list is empty — nothing to update.", "What's On Your Mind?");
                return;
            }

            if (theListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to update.", "Update What?");
                return;
            }

            if (itemTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please enter some text first.", "What's the Item Again?");
                return;
            }

            theListBox.Items[theListBox.SelectedIndex] = itemTextBox.Text.Trim();

            itemTextBox.Clear();
            itemTextBox.Focus();
        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            if (theListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to remove.", "Remove What?");
                return;
            }

            theListBox.Items.RemoveAt(theListBox.SelectedIndex);

            itemTextBox.Clear();
            itemTextBox.Focus();
        }

        private void swornStudyList_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Would you want to go back and save any changes before closing?", "Hodld the Door!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else if (result == DialogResult.No)
            {
                ;
            }
        }
    }
}
