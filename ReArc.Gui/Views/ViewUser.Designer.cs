namespace ReArc.Gui.Views
{
    partial class ViewUser
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUser));
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            Tabs = new TabControl();
            OverviewTab = new TabPage();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            FilesystemPercentageLabel = new Label();
            ByteUsageLabel = new Label();
            FilesystemQuotaBar = new ProgressBar();
            groupBox1 = new GroupBox();
            UserIdLabel = new Label();
            EmailLabel = new Label();
            UsernameLabel = new Label();
            ProfilePictureBox = new PictureBox();
            BugReportsTab = new TabPage();
            SharesTab = new TabPage();
            AccessorsTab = new TabPage();
            TokensTab = new TabPage();
            IndexesTab = new TabPage();
            StoreItemsTab = new TabPage();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            panel2 = new Panel();
            groupBox3 = new GroupBox();
            label1 = new Label();
            TokensLabel = new Label();
            SharesLabel = new Label();
            label4 = new Label();
            label11 = new Label();
            label6 = new Label();
            MessagesLabel = new Label();
            ActivitiesLabel = new Label();
            label9 = new Label();
            BugHuntsLabel = new Label();
            IndexingsLabel = new Label();
            label3 = new Label();
            label7 = new Label();
            AccessorsLabel = new Label();
            toolStrip1 = new ToolStrip();
            CredentialsMenu = new ToolStripDropDownButton();
            ChangeEmailAction = new ToolStripMenuItem();
            ChangePasswordAction = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            Manage2faAction = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            LogOutAction = new ToolStripMenuItem();
            DangerZoneMenu = new ToolStripDropDownButton();
            ApprovedAction = new ToolStripMenuItem();
            AdministratorAction = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            DeleteUserAction = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            QuickSwitcher = new ToolStripDropDownButton();
            CopyMenu = new ToolStripDropDownButton();
            UsernameCopyAction = new ToolStripMenuItem();
            UserIdCopyAction = new ToolStripMenuItem();
            EmailAddressCopyAction = new ToolStripMenuItem();
            ProfilePictureCopyAction = new ToolStripMenuItem();
            imageList1 = new ImageList(components);
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            Tabs.SuspendLayout();
            OverviewTab.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).BeginInit();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel2.Controls.Add(toolStrip1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(854, 476);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 25);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(854, 451);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(Tabs);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(15, 15, 0, 15);
            panel1.Size = new Size(604, 451);
            panel1.TabIndex = 0;
            // 
            // Tabs
            // 
            Tabs.Controls.Add(OverviewTab);
            Tabs.Controls.Add(BugReportsTab);
            Tabs.Controls.Add(SharesTab);
            Tabs.Controls.Add(AccessorsTab);
            Tabs.Controls.Add(TokensTab);
            Tabs.Controls.Add(IndexesTab);
            Tabs.Controls.Add(StoreItemsTab);
            Tabs.Controls.Add(tabPage1);
            Tabs.Controls.Add(tabPage2);
            Tabs.Dock = DockStyle.Fill;
            Tabs.Location = new Point(15, 15);
            Tabs.Margin = new Padding(0);
            Tabs.Name = "Tabs";
            Tabs.SelectedIndex = 0;
            Tabs.Size = new Size(589, 421);
            Tabs.TabIndex = 0;
            Tabs.SelectedIndexChanged += TabControl_IndexChanged;
            // 
            // OverviewTab
            // 
            OverviewTab.Controls.Add(groupBox2);
            OverviewTab.Controls.Add(groupBox1);
            OverviewTab.Location = new Point(4, 24);
            OverviewTab.Name = "OverviewTab";
            OverviewTab.Padding = new Padding(10);
            OverviewTab.Size = new Size(581, 393);
            OverviewTab.TabIndex = 0;
            OverviewTab.Text = "Overview";
            OverviewTab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(FilesystemPercentageLabel);
            groupBox2.Controls.Add(ByteUsageLabel);
            groupBox2.Controls.Add(FilesystemQuotaBar);
            groupBox2.Location = new Point(310, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10);
            groupBox2.Size = new Size(258, 106);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filesystem";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Icons.userfs32;
            pictureBox1.Location = new Point(213, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FilesystemPercentageLabel
            // 
            FilesystemPercentageLabel.AutoSize = true;
            FilesystemPercentageLabel.ForeColor = SystemColors.ControlDark;
            FilesystemPercentageLabel.Location = new Point(10, 78);
            FilesystemPercentageLabel.Name = "FilesystemPercentageLabel";
            FilesystemPercentageLabel.Size = new Size(23, 15);
            FilesystemPercentageLabel.TabIndex = 2;
            FilesystemPercentageLabel.Text = "0%";
            // 
            // ByteUsageLabel
            // 
            ByteUsageLabel.AutoSize = true;
            ByteUsageLabel.Font = new Font("Segoe UI", 9F);
            ByteUsageLabel.Location = new Point(10, 54);
            ByteUsageLabel.Margin = new Padding(0);
            ByteUsageLabel.Name = "ByteUsageLabel";
            ByteUsageLabel.Size = new Size(92, 15);
            ByteUsageLabel.TabIndex = 1;
            ByteUsageLabel.Text = "0 bytes / 0 bytes";
            // 
            // FilesystemQuotaBar
            // 
            FilesystemQuotaBar.Location = new Point(10, 26);
            FilesystemQuotaBar.Margin = new Padding(0);
            FilesystemQuotaBar.Name = "FilesystemQuotaBar";
            FilesystemQuotaBar.Size = new Size(235, 23);
            FilesystemQuotaBar.Style = ProgressBarStyle.Continuous;
            FilesystemQuotaBar.TabIndex = 0;
            FilesystemQuotaBar.Value = 50;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(UserIdLabel);
            groupBox1.Controls.Add(EmailLabel);
            groupBox1.Controls.Add(UsernameLabel);
            groupBox1.Controls.Add(ProfilePictureBox);
            groupBox1.Location = new Point(10, 13);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10);
            groupBox1.Size = new Size(287, 106);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Information";
            // 
            // UserIdLabel
            // 
            UserIdLabel.AutoSize = true;
            UserIdLabel.BackColor = Color.Transparent;
            UserIdLabel.ForeColor = SystemColors.ControlDark;
            UserIdLabel.Location = new Point(83, 78);
            UserIdLabel.Name = "UserIdLabel";
            UserIdLabel.Size = new Size(39, 15);
            UserIdLabel.TabIndex = 3;
            UserIdLabel.Text = "userid";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(83, 49);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(36, 15);
            EmailLabel.TabIndex = 2;
            EmailLabel.Text = "email";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            UsernameLabel.Location = new Point(83, 29);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(78, 20);
            UsernameLabel.TabIndex = 1;
            UsernameLabel.Text = "username";
            // 
            // ProfilePictureBox
            // 
            ProfilePictureBox.InitialImage = Properties.Icons.user;
            ProfilePictureBox.Location = new Point(13, 29);
            ProfilePictureBox.Name = "ProfilePictureBox";
            ProfilePictureBox.Size = new Size(64, 64);
            ProfilePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            ProfilePictureBox.TabIndex = 0;
            ProfilePictureBox.TabStop = false;
            // 
            // BugReportsTab
            // 
            BugReportsTab.Location = new Point(4, 24);
            BugReportsTab.Name = "BugReportsTab";
            BugReportsTab.Size = new Size(581, 393);
            BugReportsTab.TabIndex = 1;
            BugReportsTab.Text = "Bug Reports";
            BugReportsTab.UseVisualStyleBackColor = true;
            // 
            // SharesTab
            // 
            SharesTab.Location = new Point(4, 24);
            SharesTab.Name = "SharesTab";
            SharesTab.Padding = new Padding(3);
            SharesTab.Size = new Size(581, 393);
            SharesTab.TabIndex = 2;
            SharesTab.Text = "Shares";
            SharesTab.UseVisualStyleBackColor = true;
            // 
            // AccessorsTab
            // 
            AccessorsTab.Location = new Point(4, 24);
            AccessorsTab.Name = "AccessorsTab";
            AccessorsTab.Padding = new Padding(3);
            AccessorsTab.Size = new Size(581, 393);
            AccessorsTab.TabIndex = 3;
            AccessorsTab.Text = "Accessors";
            AccessorsTab.UseVisualStyleBackColor = true;
            // 
            // TokensTab
            // 
            TokensTab.Location = new Point(4, 24);
            TokensTab.Name = "TokensTab";
            TokensTab.Padding = new Padding(3);
            TokensTab.Size = new Size(581, 393);
            TokensTab.TabIndex = 4;
            TokensTab.Text = "Tokens";
            TokensTab.UseVisualStyleBackColor = true;
            // 
            // IndexesTab
            // 
            IndexesTab.Location = new Point(4, 24);
            IndexesTab.Name = "IndexesTab";
            IndexesTab.Padding = new Padding(3);
            IndexesTab.Size = new Size(581, 393);
            IndexesTab.TabIndex = 5;
            IndexesTab.Text = "Indexes";
            IndexesTab.UseVisualStyleBackColor = true;
            // 
            // StoreItemsTab
            // 
            StoreItemsTab.Location = new Point(4, 24);
            StoreItemsTab.Name = "StoreItemsTab";
            StoreItemsTab.Padding = new Padding(3);
            StoreItemsTab.Size = new Size(581, 393);
            StoreItemsTab.TabIndex = 6;
            StoreItemsTab.Text = "Store Items";
            StoreItemsTab.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(581, 393);
            tabPage1.TabIndex = 7;
            tabPage1.Text = "Activity";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(581, 393);
            tabPage2.TabIndex = 8;
            tabPage2.Text = "Scopes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.dashboardstatbg;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(groupBox3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(604, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(15);
            panel2.Size = new Size(250, 451);
            panel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(TokensLabel);
            groupBox3.Controls.Add(SharesLabel);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(MessagesLabel);
            groupBox3.Controls.Add(ActivitiesLabel);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(BugHuntsLabel);
            groupBox3.Controls.Add(IndexingsLabel);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(AccessorsLabel);
            groupBox3.Location = new Point(18, 18);
            groupBox3.Margin = new Padding(0);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(10);
            groupBox3.Size = new Size(214, 418);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "User Statistics";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(13, 26);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 16;
            label1.Text = "Login Activities";
            // 
            // TokensLabel
            // 
            TokensLabel.AutoSize = true;
            TokensLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TokensLabel.Location = new Point(13, 97);
            TokensLabel.Name = "TokensLabel";
            TokensLabel.Size = new Size(25, 32);
            TokensLabel.TabIndex = 19;
            TokensLabel.Text = "?";
            // 
            // SharesLabel
            // 
            SharesLabel.AutoSize = true;
            SharesLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            SharesLabel.Location = new Point(13, 377);
            SharesLabel.Name = "SharesLabel";
            SharesLabel.Size = new Size(25, 32);
            SharesLabel.TabIndex = 29;
            SharesLabel.Text = "?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(13, 82);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 18;
            label4.Text = "Tokens";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Navy;
            label11.Location = new Point(13, 362);
            label11.Name = "label11";
            label11.Size = new Size(78, 15);
            label11.TabIndex = 28;
            label11.Text = "Shared Drives";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(13, 138);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 20;
            label6.Text = "Bug Reports";
            // 
            // MessagesLabel
            // 
            MessagesLabel.AutoSize = true;
            MessagesLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            MessagesLabel.Location = new Point(13, 321);
            MessagesLabel.Name = "MessagesLabel";
            MessagesLabel.Size = new Size(25, 32);
            MessagesLabel.TabIndex = 27;
            MessagesLabel.Text = "?";
            // 
            // ActivitiesLabel
            // 
            ActivitiesLabel.AutoSize = true;
            ActivitiesLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            ActivitiesLabel.Location = new Point(13, 41);
            ActivitiesLabel.Name = "ActivitiesLabel";
            ActivitiesLabel.Size = new Size(25, 32);
            ActivitiesLabel.TabIndex = 17;
            ActivitiesLabel.Text = "?";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(13, 306);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 26;
            label9.Text = "Messages";
            // 
            // BugHuntsLabel
            // 
            BugHuntsLabel.AutoSize = true;
            BugHuntsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            BugHuntsLabel.Location = new Point(13, 153);
            BugHuntsLabel.Name = "BugHuntsLabel";
            BugHuntsLabel.Size = new Size(25, 32);
            BugHuntsLabel.TabIndex = 21;
            BugHuntsLabel.Text = "?";
            // 
            // IndexingsLabel
            // 
            IndexingsLabel.AutoSize = true;
            IndexingsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            IndexingsLabel.Location = new Point(13, 265);
            IndexingsLabel.Name = "IndexingsLabel";
            IndexingsLabel.Size = new Size(25, 32);
            IndexingsLabel.TabIndex = 25;
            IndexingsLabel.Text = "?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(13, 194);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 22;
            label3.Text = "Filesystem Accessors";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(13, 250);
            label7.Name = "label7";
            label7.Size = new Size(115, 15);
            label7.TabIndex = 24;
            label7.Text = "Filesystem Indexings";
            // 
            // AccessorsLabel
            // 
            AccessorsLabel.AutoSize = true;
            AccessorsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            AccessorsLabel.Location = new Point(13, 209);
            AccessorsLabel.Name = "AccessorsLabel";
            AccessorsLabel.Size = new Size(25, 32);
            AccessorsLabel.TabIndex = 23;
            AccessorsLabel.Text = "?";
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { CredentialsMenu, DangerZoneMenu, toolStripSeparator4, QuickSwitcher, CopyMenu });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(854, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // CredentialsMenu
            // 
            CredentialsMenu.DropDownItems.AddRange(new ToolStripItem[] { ChangeEmailAction, ChangePasswordAction, toolStripSeparator1, Manage2faAction, toolStripSeparator2, LogOutAction });
            CredentialsMenu.Image = Properties.Icons.tokens;
            CredentialsMenu.ImageTransparentColor = Color.Magenta;
            CredentialsMenu.Name = "CredentialsMenu";
            CredentialsMenu.Size = new Size(95, 22);
            CredentialsMenu.Text = "Credentials";
            // 
            // ChangeEmailAction
            // 
            ChangeEmailAction.Image = Properties.Icons.mail;
            ChangeEmailAction.Name = "ChangeEmailAction";
            ChangeEmailAction.Size = new Size(178, 22);
            ChangeEmailAction.Text = "Change email...";
            ChangeEmailAction.Click += ChangeEmailAction_Click;
            // 
            // ChangePasswordAction
            // 
            ChangePasswordAction.Image = Properties.Icons.tokens;
            ChangePasswordAction.Name = "ChangePasswordAction";
            ChangePasswordAction.Size = new Size(178, 22);
            ChangePasswordAction.Text = "Reset password...";
            ChangePasswordAction.Click += ChangePasswordAction_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(175, 6);
            // 
            // Manage2faAction
            // 
            Manage2faAction.Image = Properties.Icons.totp;
            Manage2faAction.Name = "Manage2faAction";
            Manage2faAction.Size = new Size(178, 22);
            Manage2faAction.Text = "Manage 2FA";
            Manage2faAction.Click += Manage2faAction_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(175, 6);
            // 
            // LogOutAction
            // 
            LogOutAction.Image = Properties.Icons.logout;
            LogOutAction.Name = "LogOutAction";
            LogOutAction.Size = new Size(178, 22);
            LogOutAction.Text = "Log out everywhere";
            // 
            // DangerZoneMenu
            // 
            DangerZoneMenu.DropDownItems.AddRange(new ToolStripItem[] { ApprovedAction, AdministratorAction, toolStripSeparator3, DeleteUserAction });
            DangerZoneMenu.Image = Properties.Icons.warning;
            DangerZoneMenu.ImageTransparentColor = Color.Magenta;
            DangerZoneMenu.Name = "DangerZoneMenu";
            DangerZoneMenu.Size = new Size(104, 22);
            DangerZoneMenu.Text = "Danger Zone";
            // 
            // ApprovedAction
            // 
            ApprovedAction.Image = Properties.Icons.padlock;
            ApprovedAction.Name = "ApprovedAction";
            ApprovedAction.Size = new Size(180, 22);
            ApprovedAction.Text = "Approved";
            ApprovedAction.Click += ApprovedAction_Click;
            // 
            // AdministratorAction
            // 
            AdministratorAction.Image = Properties.Icons.administrator;
            AdministratorAction.Name = "AdministratorAction";
            AdministratorAction.Size = new Size(180, 22);
            AdministratorAction.Text = "Administrator";
            AdministratorAction.Click += AdministratorAction_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(177, 6);
            // 
            // DeleteUserAction
            // 
            DeleteUserAction.Image = Properties.Icons.recycle;
            DeleteUserAction.Name = "DeleteUserAction";
            DeleteUserAction.Size = new Size(180, 22);
            DeleteUserAction.Text = "Delete User";
            DeleteUserAction.Click += DeleteUserAction_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
            // 
            // QuickSwitcher
            // 
            QuickSwitcher.Alignment = ToolStripItemAlignment.Right;
            QuickSwitcher.Image = Properties.Icons.users;
            QuickSwitcher.ImageTransparentColor = Color.Magenta;
            QuickSwitcher.Name = "QuickSwitcher";
            QuickSwitcher.Size = new Size(88, 22);
            QuickSwitcher.Text = "username";
            // 
            // CopyMenu
            // 
            CopyMenu.DropDownItems.AddRange(new ToolStripItem[] { UsernameCopyAction, UserIdCopyAction, EmailAddressCopyAction, ProfilePictureCopyAction });
            CopyMenu.Image = Properties.Icons.clipboard;
            CopyMenu.ImageTransparentColor = Color.Magenta;
            CopyMenu.Name = "CopyMenu";
            CopyMenu.Size = new Size(73, 22);
            CopyMenu.Text = "Copy...";
            // 
            // UsernameCopyAction
            // 
            UsernameCopyAction.Name = "UsernameCopyAction";
            UsernameCopyAction.Size = new Size(180, 22);
            UsernameCopyAction.Text = "Username";
            UsernameCopyAction.Click += UsernameCopyAction_Click;
            // 
            // UserIdCopyAction
            // 
            UserIdCopyAction.Name = "UserIdCopyAction";
            UserIdCopyAction.Size = new Size(180, 22);
            UserIdCopyAction.Text = "User ID";
            UserIdCopyAction.Click += UserIdCopyAction_Click;
            // 
            // EmailAddressCopyAction
            // 
            EmailAddressCopyAction.Name = "EmailAddressCopyAction";
            EmailAddressCopyAction.Size = new Size(180, 22);
            EmailAddressCopyAction.Text = "Email Address";
            EmailAddressCopyAction.Click += EmailAddressCopyAction_Click;
            // 
            // ProfilePictureCopyAction
            // 
            ProfilePictureCopyAction.Name = "ProfilePictureCopyAction";
            ProfilePictureCopyAction.Size = new Size(180, 22);
            ProfilePictureCopyAction.Text = "Profile Picture URL";
            ProfilePictureCopyAction.Click += ProfilePictureCopyAction_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "cabinet1.png");
            imageList1.Images.SetKeyName(1, "crash16.png");
            imageList1.Images.SetKeyName(2, "id48.png");
            imageList1.Images.SetKeyName(3, "installer16.png");
            imageList1.Images.SetKeyName(4, "keys16.png");
            imageList1.Images.SetKeyName(5, "lock16.png");
            imageList1.Images.SetKeyName(6, "share16.png");
            // 
            // ViewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel2);
            Margin = new Padding(0);
            Name = "ViewUser";
            Size = new Size(854, 476);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            Tabs.ResumeLayout(false);
            OverviewTab.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).EndInit();
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TabControl Tabs;
        private TabPage OverviewTab;
        private GroupBox groupBox1;
        private Label UserIdLabel;
        private Label EmailLabel;
        private Label UsernameLabel;
        private PictureBox ProfilePictureBox;
        private TabPage BugReportsTab;
        private TabPage SharesTab;
        private TabPage AccessorsTab;
        private TabPage TokensTab;
        private TabPage IndexesTab;
        private TabPage StoreItemsTab;
        private Panel panel2;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton CredentialsMenu;
        private ToolStripMenuItem ChangeEmailAction;
        private ToolStripMenuItem ChangePasswordAction;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem Manage2faAction;
        private ToolStripDropDownButton DangerZoneMenu;
        private GroupBox groupBox2;
        private Label FilesystemPercentageLabel;
        private Label ByteUsageLabel;
        private ProgressBar FilesystemQuotaBar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem LogOutAction;
        private ToolStripMenuItem ApprovedAction;
        private ToolStripMenuItem AdministratorAction;
        private PictureBox pictureBox1;
        private GroupBox groupBox3;
        private Label label1;
        private Label TokensLabel;
        private Label SharesLabel;
        private Label label4;
        private Label label11;
        private Label label6;
        private Label MessagesLabel;
        private Label ActivitiesLabel;
        private Label label9;
        private Label BugHuntsLabel;
        private Label IndexingsLabel;
        private Label label3;
        private Label label7;
        private Label AccessorsLabel;
        private ToolStripDropDownButton QuickSwitcher;
        private ImageList imageList1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem DeleteUserAction;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ToolStripDropDownButton CopyMenu;
        private ToolStripMenuItem UsernameCopyAction;
        private ToolStripMenuItem UserIdCopyAction;
        private ToolStripMenuItem EmailAddressCopyAction;
        private ToolStripMenuItem ProfilePictureCopyAction;
    }
}
