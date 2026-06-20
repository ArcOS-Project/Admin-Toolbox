namespace ReArc.Gui
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            PagePanel = new Panel();
            BetterPagePanel = new Panel();
            toolStrip1 = new ToolStrip();
            UsernameButton = new ToolStripDropDownButton();
            usernameToolStripMenuItem = new ToolStripMenuItem();
            emailToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            ServerButton = new ToolStripDropDownButton();
            ServerUrlItem = new ToolStripMenuItem();
            disconnectToolStripMenuItem = new ToolStripMenuItem();
            CurrentPageLabel = new ToolStripButton();
            panel2 = new Panel();
            SideMenuStrip = new MenuStrip();
            panel3 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            VersionLabel = new Label();
            pictureBox2 = new PictureBox();
            ServerLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            PagePanel.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1084, 641);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(PagePanel, 1, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 75);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(1084, 566);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // PagePanel
            // 
            PagePanel.AutoSize = true;
            PagePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PagePanel.BackColor = Color.White;
            PagePanel.Controls.Add(BetterPagePanel);
            PagePanel.Controls.Add(toolStrip1);
            PagePanel.Dock = DockStyle.Fill;
            PagePanel.Location = new Point(200, 0);
            PagePanel.Margin = new Padding(0);
            PagePanel.Name = "PagePanel";
            PagePanel.Size = new Size(884, 566);
            PagePanel.TabIndex = 0;
            // 
            // BetterPagePanel
            // 
            BetterPagePanel.Dock = DockStyle.Fill;
            BetterPagePanel.Location = new Point(0, 0);
            BetterPagePanel.Name = "BetterPagePanel";
            BetterPagePanel.Size = new Size(884, 541);
            BetterPagePanel.TabIndex = 2;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { UsernameButton, ServerButton, CurrentPageLabel });
            toolStrip1.Location = new Point(0, 541);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(884, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // UsernameButton
            // 
            UsernameButton.Alignment = ToolStripItemAlignment.Right;
            UsernameButton.DropDownItems.AddRange(new ToolStripItem[] { usernameToolStripMenuItem, emailToolStripMenuItem, toolStripSeparator2, logOutToolStripMenuItem });
            UsernameButton.Image = (Image)resources.GetObject("UsernameButton.Image");
            UsernameButton.ImageTransparentColor = Color.Magenta;
            UsernameButton.Name = "UsernameButton";
            UsernameButton.Size = new Size(88, 22);
            UsernameButton.Text = "username";
            // 
            // usernameToolStripMenuItem
            // 
            usernameToolStripMenuItem.Enabled = false;
            usernameToolStripMenuItem.Image = Properties.Icons.user;
            usernameToolStripMenuItem.Name = "usernameToolStripMenuItem";
            usernameToolStripMenuItem.Size = new Size(134, 22);
            usernameToolStripMenuItem.Text = "(username)";
            // 
            // emailToolStripMenuItem
            // 
            emailToolStripMenuItem.Enabled = false;
            emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            emailToolStripMenuItem.Size = new Size(134, 22);
            emailToolStripMenuItem.Text = "(email)";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(131, 6);
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Image = Properties.Icons.logout;
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(134, 22);
            logOutToolStripMenuItem.Text = "Log out";
            logOutToolStripMenuItem.Click += LogOutToolStripMenuItem_Click;
            // 
            // ServerButton
            // 
            ServerButton.Alignment = ToolStripItemAlignment.Right;
            ServerButton.DropDownItems.AddRange(new ToolStripItem[] { ServerUrlItem, disconnectToolStripMenuItem });
            ServerButton.Image = Properties.Icons.globe;
            ServerButton.ImageTransparentColor = Color.Magenta;
            ServerButton.Name = "ServerButton";
            ServerButton.Size = new Size(67, 22);
            ServerButton.Text = "server";
            // 
            // ServerUrlItem
            // 
            ServerUrlItem.Enabled = false;
            ServerUrlItem.Name = "ServerUrlItem";
            ServerUrlItem.Size = new Size(133, 22);
            ServerUrlItem.Text = "(server url)";
            // 
            // disconnectToolStripMenuItem
            // 
            disconnectToolStripMenuItem.Image = Properties.Icons.disconnect;
            disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            disconnectToolStripMenuItem.Size = new Size(133, 22);
            disconnectToolStripMenuItem.Text = "Disconnect";
            disconnectToolStripMenuItem.Click += DisconnectToolStripMenuItem_Click;
            // 
            // CurrentPageLabel
            // 
            CurrentPageLabel.Image = (Image)resources.GetObject("CurrentPageLabel.Image");
            CurrentPageLabel.ImageTransparentColor = Color.Magenta;
            CurrentPageLabel.Name = "CurrentPageLabel";
            CurrentPageLabel.Size = new Size(53, 22);
            CurrentPageLabel.Text = "page";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.FromArgb(244, 250, 255);
            panel2.BackgroundImage = Properties.Resources.sidebarbg;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(SideMenuStrip);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 566);
            panel2.TabIndex = 1;
            // 
            // SideMenuStrip
            // 
            SideMenuStrip.BackColor = Color.Transparent;
            SideMenuStrip.Dock = DockStyle.Fill;
            SideMenuStrip.LayoutStyle = ToolStripLayoutStyle.Table;
            SideMenuStrip.Location = new Point(0, 0);
            SideMenuStrip.Name = "SideMenuStrip";
            SideMenuStrip.Padding = new Padding(15);
            SideMenuStrip.Size = new Size(200, 566);
            SideMenuStrip.TabIndex = 0;
            SideMenuStrip.Text = "menuStrip1";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(244, 250, 255);
            panel3.Controls.Add(tableLayoutPanel3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1084, 75);
            panel3.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel3.Controls.Add(panel1, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1084, 75);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.mainbanner;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 75);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(VersionLabel);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(ServerLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(400, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(684, 75);
            panel1.TabIndex = 3;
            // 
            // VersionLabel
            // 
            VersionLabel.Anchor = AnchorStyles.Right;
            VersionLabel.Location = new Point(571, 12);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(100, 23);
            VersionLabel.TabIndex = 2;
            VersionLabel.Text = "v0.0.0";
            VersionLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Right;
            pictureBox2.Image = Properties.Icons.globe;
            pictureBox2.Location = new Point(655, 46);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(16, 16);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // ServerLabel
            // 
            ServerLabel.Anchor = AnchorStyles.Right;
            ServerLabel.Location = new Point(483, 46);
            ServerLabel.Name = "ServerLabel";
            ServerLabel.Size = new Size(169, 16);
            ServerLabel.TabIndex = 0;
            ServerLabel.Text = "server";
            ServerLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 641);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1100, 680);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ArcOS Administrative Toolbox";
            Load += MainForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            PagePanel.ResumeLayout(false);
            PagePanel.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel PagePanel;
        private Panel panel2;
        private Panel panel3;
        private MenuStrip SideMenuStrip;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label ServerLabel;
        private Label VersionLabel;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton UsernameButton;
        private ToolStripMenuItem usernameToolStripMenuItem;
        private ToolStripMenuItem emailToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripDropDownButton ServerButton;
        private ToolStripMenuItem ServerUrlItem;
        private ToolStripMenuItem disconnectToolStripMenuItem;
        private Panel BetterPagePanel;
        private ToolStripButton CurrentPageLabel;
    }
}