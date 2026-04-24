namespace SwornStudyList
{
    partial class SwornStudyListForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            theListBox = new ListBox();
            openListDialog = new OpenFileDialog();
            itemLabel = new Label();
            itemTextBox = new TextBox();
            addItemButton = new Button();
            tableLayoutPanelTop = new TableLayoutPanel();
            flowLayoutPanelBottom = new FlowLayoutPanel();
            updateItemButton = new Button();
            removeItemButton = new Button();
            loadListButton = new Button();
            saveListButton = new Button();
            saveListDialog = new SaveFileDialog();
            tableLayoutPanelTop.SuspendLayout();
            flowLayoutPanelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            tableLayoutPanelTop.SetColumnSpan(titleLabel, 2);
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(3, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(778, 50);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "I solemnly swear to study and practice the following for the Midsemester:";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // theListBox
            // 
            theListBox.BackColor = SystemColors.Window;
            theListBox.Dock = DockStyle.Fill;
            theListBox.Font = new Font("Segoe UI", 11F);
            theListBox.FormattingEnabled = true;
            theListBox.ItemHeight = 20;
            theListBox.Items.AddRange(new object[] { "bah", "bohe" });
            theListBox.Location = new Point(3, 53);
            theListBox.Name = "theListBox";
            theListBox.Size = new Size(478, 505);
            theListBox.TabIndex = 1;
            theListBox.SelectedIndexChanged += theListBox_SelectedIndexChanged;
            // 
            // itemLabel
            // 
            itemLabel.Dock = DockStyle.Left;
            itemLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemLabel.Location = new Point(3, 0);
            itemLabel.Name = "itemLabel";
            itemLabel.Size = new Size(291, 20);
            itemLabel.TabIndex = 4;
            itemLabel.Text = "Study item";
            itemLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // itemTextBox
            // 
            itemTextBox.BackColor = SystemColors.Window;
            itemTextBox.BorderStyle = BorderStyle.FixedSingle;
            itemTextBox.Font = new Font("Segoe UI", 11F);
            itemTextBox.Location = new Point(3, 23);
            itemTextBox.Multiline = true;
            itemTextBox.Name = "itemTextBox";
            itemTextBox.Size = new Size(291, 84);
            itemTextBox.TabIndex = 5;
            // 
            // addItemButton
            // 
            addItemButton.BackColor = SystemColors.ButtonFace;
            addItemButton.Font = new Font("Segoe UI", 11F);
            addItemButton.Location = new Point(3, 149);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(291, 30);
            addItemButton.TabIndex = 7;
            addItemButton.Text = "Add as new";
            addItemButton.UseVisualStyleBackColor = false;
            addItemButton.Click += addItemButton_Click;
            // 
            // tableLayoutPanelTop
            // 
            tableLayoutPanelTop.ColumnCount = 2;
            tableLayoutPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanelTop.Controls.Add(titleLabel, 0, 0);
            tableLayoutPanelTop.Controls.Add(theListBox, 0, 1);
            tableLayoutPanelTop.Controls.Add(flowLayoutPanelBottom, 1, 1);
            tableLayoutPanelTop.Dock = DockStyle.Fill;
            tableLayoutPanelTop.Location = new Point(0, 0);
            tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            tableLayoutPanelTop.RowCount = 2;
            tableLayoutPanelTop.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelTop.Size = new Size(784, 561);
            tableLayoutPanelTop.TabIndex = 8;
            // 
            // flowLayoutPanelBottom
            // 
            flowLayoutPanelBottom.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanelBottom.Controls.Add(itemLabel);
            flowLayoutPanelBottom.Controls.Add(itemTextBox);
            flowLayoutPanelBottom.Controls.Add(updateItemButton);
            flowLayoutPanelBottom.Controls.Add(addItemButton);
            flowLayoutPanelBottom.Controls.Add(removeItemButton);
            flowLayoutPanelBottom.Controls.Add(loadListButton);
            flowLayoutPanelBottom.Controls.Add(saveListButton);
            flowLayoutPanelBottom.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelBottom.Location = new Point(487, 53);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Size = new Size(294, 505);
            flowLayoutPanelBottom.TabIndex = 4;
            flowLayoutPanelBottom.WrapContents = false;
            // 
            // updateItemButton
            // 
            updateItemButton.AutoSize = true;
            updateItemButton.BackColor = SystemColors.ButtonFace;
            updateItemButton.Dock = DockStyle.Left;
            updateItemButton.Font = new Font("Segoe UI", 11F);
            updateItemButton.Location = new Point(3, 113);
            updateItemButton.Name = "updateItemButton";
            updateItemButton.Size = new Size(291, 30);
            updateItemButton.TabIndex = 9;
            updateItemButton.Text = "Update";
            updateItemButton.UseVisualStyleBackColor = false;
            updateItemButton.Click += updateItemButton_Click;
            // 
            // removeItemButton
            // 
            removeItemButton.AutoSize = true;
            removeItemButton.BackColor = SystemColors.ButtonFace;
            removeItemButton.Dock = DockStyle.Left;
            removeItemButton.Font = new Font("Segoe UI", 11F);
            removeItemButton.Location = new Point(3, 185);
            removeItemButton.Name = "removeItemButton";
            removeItemButton.Size = new Size(291, 30);
            removeItemButton.TabIndex = 8;
            removeItemButton.Text = "Remove";
            removeItemButton.UseVisualStyleBackColor = false;
            // 
            // loadListButton
            // 
            loadListButton.AutoSize = true;
            loadListButton.BackColor = SystemColors.ButtonFace;
            loadListButton.Dock = DockStyle.Left;
            loadListButton.Font = new Font("Microsoft Sans Serif", 11.25F);
            loadListButton.Location = new Point(3, 221);
            loadListButton.Name = "loadListButton";
            loadListButton.Size = new Size(291, 30);
            loadListButton.TabIndex = 2;
            loadListButton.Text = "Open list";
            loadListButton.UseVisualStyleBackColor = false;
            loadListButton.Click += loadListButton_Click;
            // 
            // saveListButton
            // 
            saveListButton.AutoSize = true;
            saveListButton.BackColor = SystemColors.ButtonFace;
            saveListButton.Dock = DockStyle.Left;
            saveListButton.Font = new Font("Microsoft Sans Serif", 11.25F);
            saveListButton.Location = new Point(3, 257);
            saveListButton.Name = "saveListButton";
            saveListButton.Size = new Size(291, 30);
            saveListButton.TabIndex = 6;
            saveListButton.Text = "Save list";
            saveListButton.UseVisualStyleBackColor = false;
            saveListButton.Click += saveListButton_Click;
            // 
            // SwornStudyListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(784, 561);
            Controls.Add(tableLayoutPanelTop);
            MinimumSize = new Size(800, 600);
            Name = "SwornStudyListForm";
            Text = "Things I swear I'll study for Midsemester test! 🙄";
            FormClosing += swornStudyList_FormClosing;
            tableLayoutPanelTop.ResumeLayout(false);
            tableLayoutPanelTop.PerformLayout();
            flowLayoutPanelBottom.ResumeLayout(false);
            flowLayoutPanelBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label titleLabel;
        private ListBox theListBox;
        private OpenFileDialog openListDialog;
        private Label itemLabel;
        private TextBox itemTextBox;
        private Button addItemButton;
        private TableLayoutPanel tableLayoutPanelTop;
        private FlowLayoutPanel flowLayoutPanelBottom;
        private Button loadListButton;
        private Button saveListButton;
        private Button removeItemButton;
        private Button updateItemButton;
        private SaveFileDialog saveListDialog;
    }
}
