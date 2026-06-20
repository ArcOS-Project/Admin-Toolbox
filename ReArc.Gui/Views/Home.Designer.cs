namespace ReArc.Gui.Views
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label1 = new Label();
            TokensLabel = new Label();
            UsersLabel = new Label();
            label4 = new Label();
            IndexesLabel = new Label();
            label6 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            ActivitiesLabel = new Label();
            label13 = new Label();
            AuditLogLabel = new Label();
            label11 = new Label();
            BugReportsLabel = new Label();
            label9 = new Label();
            AccessorsLabel = new Label();
            label3 = new Label();
            label7 = new Label();
            ApprovalsLabel = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            groupBox4 = new GroupBox();
            LogsButton = new Button();
            AuditLogButton = new Button();
            ScopesButton = new Button();
            BugReportButton = new Button();
            groupBox3 = new GroupBox();
            AppStoreButton = new Button();
            SharesButton = new Button();
            FilesystemsButton = new Button();
            groupBox2 = new GroupBox();
            ActivitiesButton = new Button();
            TokensButton = new Button();
            UsersButton = new Button();
            LoggedInAsLabel = new Label();
            ProfilePictureBox = new PictureBox();
            GreetingBox = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(11, 24);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "User Tokens";
            // 
            // TokensLabel
            // 
            TokensLabel.AutoSize = true;
            TokensLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TokensLabel.Location = new Point(11, 39);
            TokensLabel.Name = "TokensLabel";
            TokensLabel.Size = new Size(25, 32);
            TokensLabel.TabIndex = 1;
            TokensLabel.Text = "?";
            // 
            // UsersLabel
            // 
            UsersLabel.AutoSize = true;
            UsersLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            UsersLabel.Location = new Point(11, 95);
            UsersLabel.Name = "UsersLabel";
            UsersLabel.Size = new Size(25, 32);
            UsersLabel.TabIndex = 3;
            UsersLabel.Text = "?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(11, 80);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 2;
            label4.Text = "User Accounts";
            // 
            // IndexesLabel
            // 
            IndexesLabel.AutoSize = true;
            IndexesLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            IndexesLabel.Location = new Point(11, 151);
            IndexesLabel.Name = "IndexesLabel";
            IndexesLabel.Size = new Size(25, 32);
            IndexesLabel.TabIndex = 5;
            IndexesLabel.Text = "?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(11, 136);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 4;
            label6.Text = "Filesystem Indexes";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(884, 546);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(634, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(15);
            panel1.Size = new Size(250, 546);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(ActivitiesLabel);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(UsersLabel);
            groupBox1.Controls.Add(AuditLogLabel);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(BugReportsLabel);
            groupBox1.Controls.Add(TokensLabel);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(IndexesLabel);
            groupBox1.Controls.Add(AccessorsLabel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(ApprovalsLabel);
            groupBox1.Location = new Point(15, 15);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(8);
            groupBox1.Size = new Size(220, 516);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Server Statistics";
            // 
            // ActivitiesLabel
            // 
            ActivitiesLabel.AutoSize = true;
            ActivitiesLabel.BackColor = Color.Transparent;
            ActivitiesLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            ActivitiesLabel.Location = new Point(11, 431);
            ActivitiesLabel.Name = "ActivitiesLabel";
            ActivitiesLabel.Size = new Size(25, 32);
            ActivitiesLabel.TabIndex = 15;
            ActivitiesLabel.Text = "?";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Navy;
            label13.Location = new Point(11, 416);
            label13.Name = "label13";
            label13.Size = new Size(88, 15);
            label13.TabIndex = 14;
            label13.Text = "Login Activities";
            // 
            // AuditLogLabel
            // 
            AuditLogLabel.AutoSize = true;
            AuditLogLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            AuditLogLabel.Location = new Point(11, 375);
            AuditLogLabel.Name = "AuditLogLabel";
            AuditLogLabel.Size = new Size(25, 32);
            AuditLogLabel.TabIndex = 13;
            AuditLogLabel.Text = "?";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Navy;
            label11.Location = new Point(11, 360);
            label11.Name = "label11";
            label11.Size = new Size(64, 15);
            label11.TabIndex = 12;
            label11.Text = "Audit Logs";
            // 
            // BugReportsLabel
            // 
            BugReportsLabel.AutoSize = true;
            BugReportsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            BugReportsLabel.Location = new Point(11, 319);
            BugReportsLabel.Name = "BugReportsLabel";
            BugReportsLabel.Size = new Size(25, 32);
            BugReportsLabel.TabIndex = 11;
            BugReportsLabel.Text = "?";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(11, 304);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 10;
            label9.Text = "Bug Reports";
            // 
            // AccessorsLabel
            // 
            AccessorsLabel.AutoSize = true;
            AccessorsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            AccessorsLabel.Location = new Point(11, 263);
            AccessorsLabel.Name = "AccessorsLabel";
            AccessorsLabel.Size = new Size(25, 32);
            AccessorsLabel.TabIndex = 9;
            AccessorsLabel.Text = "?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(11, 192);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 6;
            label3.Text = "Account Approvals";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(11, 248);
            label7.Name = "label7";
            label7.Size = new Size(117, 15);
            label7.TabIndex = 8;
            label7.Text = "Filesystem Accessors";
            // 
            // ApprovalsLabel
            // 
            ApprovalsLabel.AutoSize = true;
            ApprovalsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            ApprovalsLabel.Location = new Point(11, 207);
            ApprovalsLabel.Name = "ApprovalsLabel";
            ApprovalsLabel.Size = new Size(25, 32);
            ApprovalsLabel.TabIndex = 7;
            ApprovalsLabel.Text = "?";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(LoggedInAsLabel);
            panel2.Controls.Add(ProfilePictureBox);
            panel2.Controls.Add(GreetingBox);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(25);
            panel2.Size = new Size(634, 546);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = Properties.Resources.dashboardbg;
            pictureBox1.Location = new Point(0, 320);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 226);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(LogsButton);
            groupBox4.Controls.Add(AuditLogButton);
            groupBox4.Controls.Add(ScopesButton);
            groupBox4.Controls.Add(BugReportButton);
            groupBox4.Location = new Point(311, 89);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(10);
            groupBox4.Size = new Size(142, 165);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Administration";
            // 
            // LogsButton
            // 
            LogsButton.BackgroundImageLayout = ImageLayout.Zoom;
            LogsButton.Image = Properties.Icons.logs;
            LogsButton.ImageAlign = ContentAlignment.TopLeft;
            LogsButton.Location = new Point(13, 123);
            LogsButton.Name = "LogsButton";
            LogsButton.Padding = new Padding(2, 2, 10, 2);
            LogsButton.Size = new Size(116, 27);
            LogsButton.TabIndex = 7;
            LogsButton.Text = "Logs";
            LogsButton.TextAlign = ContentAlignment.MiddleRight;
            LogsButton.UseVisualStyleBackColor = true;
            // 
            // AuditLogButton
            // 
            AuditLogButton.BackgroundImageLayout = ImageLayout.Zoom;
            AuditLogButton.Image = Properties.Icons.audit;
            AuditLogButton.ImageAlign = ContentAlignment.TopLeft;
            AuditLogButton.Location = new Point(13, 90);
            AuditLogButton.Name = "AuditLogButton";
            AuditLogButton.Padding = new Padding(2, 2, 10, 2);
            AuditLogButton.Size = new Size(116, 27);
            AuditLogButton.TabIndex = 6;
            AuditLogButton.Text = "Audit Log";
            AuditLogButton.TextAlign = ContentAlignment.MiddleRight;
            AuditLogButton.UseVisualStyleBackColor = true;
            // 
            // ScopesButton
            // 
            ScopesButton.BackgroundImageLayout = ImageLayout.Zoom;
            ScopesButton.Image = Properties.Icons.administrator;
            ScopesButton.ImageAlign = ContentAlignment.TopLeft;
            ScopesButton.Location = new Point(13, 57);
            ScopesButton.Name = "ScopesButton";
            ScopesButton.Padding = new Padding(2, 2, 10, 2);
            ScopesButton.Size = new Size(116, 27);
            ScopesButton.TabIndex = 5;
            ScopesButton.Text = "Scopes";
            ScopesButton.TextAlign = ContentAlignment.MiddleRight;
            ScopesButton.UseVisualStyleBackColor = true;
            // 
            // BugReportButton
            // 
            BugReportButton.BackgroundImageLayout = ImageLayout.Zoom;
            BugReportButton.Image = Properties.Icons.bug;
            BugReportButton.ImageAlign = ContentAlignment.TopLeft;
            BugReportButton.Location = new Point(13, 24);
            BugReportButton.Name = "BugReportButton";
            BugReportButton.Padding = new Padding(2, 2, 10, 2);
            BugReportButton.Size = new Size(116, 27);
            BugReportButton.TabIndex = 4;
            BugReportButton.Text = "Bug Reports";
            BugReportButton.TextAlign = ContentAlignment.MiddleRight;
            BugReportButton.UseVisualStyleBackColor = true;
            BugReportButton.Click += BugReportButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(AppStoreButton);
            groupBox3.Controls.Add(SharesButton);
            groupBox3.Controls.Add(FilesystemsButton);
            groupBox3.Location = new Point(163, 89);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(10);
            groupBox3.Size = new Size(142, 165);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Content";
            // 
            // AppStoreButton
            // 
            AppStoreButton.BackgroundImageLayout = ImageLayout.Zoom;
            AppStoreButton.Image = Properties.Icons.appstore;
            AppStoreButton.ImageAlign = ContentAlignment.TopLeft;
            AppStoreButton.Location = new Point(13, 90);
            AppStoreButton.Name = "AppStoreButton";
            AppStoreButton.Padding = new Padding(2, 2, 10, 2);
            AppStoreButton.Size = new Size(116, 27);
            AppStoreButton.TabIndex = 6;
            AppStoreButton.Text = "App Store";
            AppStoreButton.TextAlign = ContentAlignment.MiddleRight;
            AppStoreButton.UseVisualStyleBackColor = true;
            // 
            // SharesButton
            // 
            SharesButton.BackgroundImageLayout = ImageLayout.Zoom;
            SharesButton.Image = Properties.Icons.share;
            SharesButton.ImageAlign = ContentAlignment.TopLeft;
            SharesButton.Location = new Point(13, 57);
            SharesButton.Name = "SharesButton";
            SharesButton.Padding = new Padding(2, 2, 10, 2);
            SharesButton.Size = new Size(116, 27);
            SharesButton.TabIndex = 5;
            SharesButton.Text = "Shares";
            SharesButton.TextAlign = ContentAlignment.MiddleRight;
            SharesButton.UseVisualStyleBackColor = true;
            SharesButton.Click += SharesButton_Click;
            // 
            // FilesystemsButton
            // 
            FilesystemsButton.BackgroundImageLayout = ImageLayout.Zoom;
            FilesystemsButton.Image = Properties.Icons.userfs;
            FilesystemsButton.ImageAlign = ContentAlignment.TopLeft;
            FilesystemsButton.Location = new Point(13, 24);
            FilesystemsButton.Name = "FilesystemsButton";
            FilesystemsButton.Padding = new Padding(2, 2, 10, 2);
            FilesystemsButton.Size = new Size(116, 27);
            FilesystemsButton.TabIndex = 4;
            FilesystemsButton.Text = "Filesystems";
            FilesystemsButton.TextAlign = ContentAlignment.MiddleRight;
            FilesystemsButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ActivitiesButton);
            groupBox2.Controls.Add(TokensButton);
            groupBox2.Controls.Add(UsersButton);
            groupBox2.Location = new Point(28, 89);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10);
            groupBox2.Size = new Size(129, 165);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Users && Security";
            // 
            // ActivitiesButton
            // 
            ActivitiesButton.BackgroundImageLayout = ImageLayout.Zoom;
            ActivitiesButton.Image = Properties.Icons.padlock;
            ActivitiesButton.ImageAlign = ContentAlignment.TopLeft;
            ActivitiesButton.Location = new Point(14, 90);
            ActivitiesButton.Name = "ActivitiesButton";
            ActivitiesButton.Padding = new Padding(2, 2, 10, 2);
            ActivitiesButton.Size = new Size(102, 27);
            ActivitiesButton.TabIndex = 6;
            ActivitiesButton.Text = "Activities";
            ActivitiesButton.TextAlign = ContentAlignment.MiddleRight;
            ActivitiesButton.UseVisualStyleBackColor = true;
            // 
            // TokensButton
            // 
            TokensButton.BackgroundImageLayout = ImageLayout.Zoom;
            TokensButton.Image = Properties.Icons.tokens;
            TokensButton.ImageAlign = ContentAlignment.TopLeft;
            TokensButton.Location = new Point(13, 57);
            TokensButton.Name = "TokensButton";
            TokensButton.Padding = new Padding(2, 2, 10, 2);
            TokensButton.Size = new Size(102, 27);
            TokensButton.TabIndex = 5;
            TokensButton.Text = "Tokens";
            TokensButton.TextAlign = ContentAlignment.MiddleRight;
            TokensButton.UseVisualStyleBackColor = true;
            // 
            // UsersButton
            // 
            UsersButton.BackgroundImageLayout = ImageLayout.Zoom;
            UsersButton.Image = Properties.Icons.users;
            UsersButton.ImageAlign = ContentAlignment.TopLeft;
            UsersButton.Location = new Point(13, 24);
            UsersButton.Name = "UsersButton";
            UsersButton.Padding = new Padding(2, 2, 10, 2);
            UsersButton.Size = new Size(102, 27);
            UsersButton.TabIndex = 4;
            UsersButton.Text = "Users";
            UsersButton.TextAlign = ContentAlignment.MiddleRight;
            UsersButton.UseVisualStyleBackColor = true;
            UsersButton.Click += UsersButton_Click;
            // 
            // LoggedInAsLabel
            // 
            LoggedInAsLabel.AutoSize = true;
            LoggedInAsLabel.Location = new Point(28, 57);
            LoggedInAsLabel.Name = "LoggedInAsLabel";
            LoggedInAsLabel.Size = new Size(173, 15);
            LoggedInAsLabel.TabIndex = 2;
            LoggedInAsLabel.Text = "Logged in as (email) on (server)";
            // 
            // ProfilePictureBox
            // 
            ProfilePictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ProfilePictureBox.BackgroundImage = Properties.Icons.user;
            ProfilePictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            ProfilePictureBox.Location = new Point(478, 28);
            ProfilePictureBox.Name = "ProfilePictureBox";
            ProfilePictureBox.Size = new Size(128, 128);
            ProfilePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            ProfilePictureBox.TabIndex = 1;
            ProfilePictureBox.TabStop = false;
            // 
            // GreetingBox
            // 
            GreetingBox.AutoSize = true;
            GreetingBox.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            GreetingBox.Location = new Point(28, 25);
            GreetingBox.Name = "GreetingBox";
            GreetingBox.Size = new Size(247, 25);
            GreetingBox.TabIndex = 0;
            GreetingBox.Text = "Good afternoon, username!";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "Home";
            Size = new Size(884, 546);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label TokensLabel;
        private Label UsersLabel;
        private Label label4;
        private Label IndexesLabel;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label ActivitiesLabel;
        private Label label13;
        private Label AuditLogLabel;
        private Label label11;
        private Label BugReportsLabel;
        private Label label9;
        private Label AccessorsLabel;
        private Label label7;
        private Label ApprovalsLabel;
        private Label label3;
        private GroupBox groupBox1;
        private Panel panel2;
        private Label LoggedInAsLabel;
        private PictureBox ProfilePictureBox;
        private Label GreetingBox;
        private GroupBox groupBox2;
        private Button ActivitiesButton;
        private Button TokensButton;
        private Button UsersButton;
        private GroupBox groupBox3;
        private Button AppStoreButton;
        private Button SharesButton;
        private Button FilesystemsButton;
        private GroupBox groupBox4;
        private Button LogsButton;
        private Button AuditLogButton;
        private Button ScopesButton;
        private Button BugReportButton;
        private PictureBox pictureBox1;
    }
}
