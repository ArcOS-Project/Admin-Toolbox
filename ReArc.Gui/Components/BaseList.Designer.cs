namespace ReArc.Gui.Components
{
    partial class BaseList<T>
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            FilterBox = new ComboBox();
            SearchButton = new Button();
            SearchBox = new TextBox();
            panel2 = new Panel();
            GridView = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridView).BeginInit();
            SuspendLayout();

            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(884, 438);
            tableLayoutPanel1.TabIndex = 0;

            panel1.Controls.Add(FilterBox);
            panel1.Controls.Add(SearchButton);
            panel1.Controls.Add(SearchBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(15, 15, 15, 0);
            panel1.Size = new Size(884, 55);
            panel1.TabIndex = 0;

            FilterBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FilterBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FilterBox.FormattingEnabled = true;
            FilterBox.Items.AddRange(_filterOptions.ToArray());
            FilterBox.Location = new Point(745, 18);
            FilterBox.Name = "FilterBox";
            FilterBox.Size = new Size(121, 23);
            FilterBox.TabIndex = 2;
            FilterBox.SelectedIndexChanged += FilterDropdown_SelectedIndexChanged;

            SearchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchButton.Image = Properties.Icons.magnifier;
            SearchButton.Location = new Point(714, 17);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(25, 25);
            SearchButton.TabIndex = 1;
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;

            SearchBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SearchBox.Location = new Point(18, 18);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(690, 23);
            SearchBox.TabIndex = 0;
            SearchBox.KeyDown += SearchBox_KeyDown;

            panel2.Controls.Add(GridView);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 55);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(15, 0, 15, 15);
            panel2.Size = new Size(884, 383);
            panel2.TabIndex = 1;
            
            GridView.AllowUserToAddRows = false;
            GridView.AllowUserToDeleteRows = false;
            GridView.BackgroundColor = Color.White;
            GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridView.Columns.AddRange(_columns.ToArray());
            GridView.Dock = DockStyle.Fill;
            GridView.GridColor = Color.White;
            GridView.Location = new Point(15, 0);
            GridView.Margin = new Padding(0);
            GridView.Name = "GridView";
            GridView.ReadOnly = true;
            GridView.RowHeadersVisible = false;
            GridView.Size = new Size(854, 368);
            GridView.TabIndex = 0;
            GridView.CellContentClick += Internal_OnCellClicked;
            GridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(tableLayoutPanel1);
            Name = "BugReportList";
            Size = new Size(884, 438);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridView).EndInit();
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private ComboBox FilterBox;
        private Button SearchButton;
        private TextBox SearchBox;
        private Panel panel2;
        private DataGridView GridView;
    }
}
