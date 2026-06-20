namespace ReArc.Gui.Account;

partial class LoginForm
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
        pictureBox1 = new PictureBox();
        tableLayoutPanel1 = new TableLayoutPanel();
        panel1 = new Panel();
        LogoutButton = new Button();
        AbortButton = new Button();
        LoginButton = new Button();
        pictureBox2 = new PictureBox();
        StatusLabel = new Label();
        PasswordBox = new TextBox();
        label3 = new Label();
        SwitchServerButton = new Button();
        UsernameBox = new TextBox();
        label2 = new Label();
        ServerBox = new TextBox();
        label1 = new Label();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        tableLayoutPanel1.SuspendLayout();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.Dock = DockStyle.Fill;
        pictureBox1.Image = Properties.Resources.banner;
        pictureBox1.Location = new Point(0, 0);
        pictureBox1.Margin = new Padding(0);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(400, 70);
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
        tableLayoutPanel1.Controls.Add(panel1, 0, 1);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.Size = new Size(400, 285);
        tableLayoutPanel1.TabIndex = 1;
        // 
        // panel1
        // 
        panel1.BackColor = SystemColors.Control;
        panel1.Controls.Add(LogoutButton);
        panel1.Controls.Add(AbortButton);
        panel1.Controls.Add(LoginButton);
        panel1.Controls.Add(pictureBox2);
        panel1.Controls.Add(StatusLabel);
        panel1.Controls.Add(PasswordBox);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(SwitchServerButton);
        panel1.Controls.Add(UsernameBox);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(ServerBox);
        panel1.Controls.Add(label1);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(0, 70);
        panel1.Margin = new Padding(0);
        panel1.Name = "panel1";
        panel1.Padding = new Padding(20);
        panel1.Size = new Size(400, 215);
        panel1.TabIndex = 1;
        // 
        // LogoutButton
        // 
        LogoutButton.Enabled = false;
        LogoutButton.Location = new Point(225, 171);
        LogoutButton.Name = "LogoutButton";
        LogoutButton.Size = new Size(75, 23);
        LogoutButton.TabIndex = 9;
        LogoutButton.Text = "Log out";
        LogoutButton.UseVisualStyleBackColor = true;
        LogoutButton.Click += LogoutButton_Click;
        // 
        // AbortButton
        // 
        AbortButton.Location = new Point(144, 171);
        AbortButton.Name = "AbortButton";
        AbortButton.Size = new Size(75, 23);
        AbortButton.TabIndex = 4;
        AbortButton.Text = "Exit";
        AbortButton.UseVisualStyleBackColor = true;
        AbortButton.Click += AbortButton_click;
        // 
        // LoginButton
        // 
        LoginButton.Location = new Point(306, 171);
        LoginButton.Name = "LoginButton";
        LoginButton.Size = new Size(75, 23);
        LoginButton.TabIndex = 5;
        LoginButton.Text = "Log in";
        LoginButton.UseVisualStyleBackColor = true;
        LoginButton.Click += LoginButton_Click;
        // 
        // pictureBox2
        // 
        pictureBox2.Image = Properties.Icons.warning;
        pictureBox2.Location = new Point(23, 123);
        pictureBox2.Margin = new Padding(0, 0, 5, 0);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(16, 16);
        pictureBox2.TabIndex = 8;
        pictureBox2.TabStop = false;
        // 
        // StatusLabel
        // 
        StatusLabel.Location = new Point(44, 123);
        StatusLabel.Margin = new Padding(0);
        StatusLabel.Name = "StatusLabel";
        StatusLabel.Size = new Size(333, 33);
        StatusLabel.TabIndex = 7;
        StatusLabel.Text = "Please enter your credentials to log in. Note that you must be an administrator to be able to access this resource.";
        // 
        // PasswordBox
        // 
        PasswordBox.AcceptsReturn = true;
        PasswordBox.Location = new Point(177, 81);
        PasswordBox.Name = "PasswordBox";
        PasswordBox.Size = new Size(200, 23);
        PasswordBox.TabIndex = 3;
        PasswordBox.UseSystemPasswordChar = true;
        PasswordBox.TextChanged += PasswordBox_TextChanged;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(23, 84);
        label3.Name = "label3";
        label3.Size = new Size(60, 15);
        label3.TabIndex = 5;
        label3.Text = "Password:";
        // 
        // SwitchServerButton
        // 
        SwitchServerButton.Location = new Point(348, 23);
        SwitchServerButton.Margin = new Padding(0);
        SwitchServerButton.Name = "SwitchServerButton";
        SwitchServerButton.Size = new Size(29, 23);
        SwitchServerButton.TabIndex = 6;
        SwitchServerButton.Text = "...";
        SwitchServerButton.UseVisualStyleBackColor = true;
        SwitchServerButton.Click += SwitchServerButton_Click;
        // 
        // UsernameBox
        // 
        UsernameBox.Location = new Point(177, 52);
        UsernameBox.Name = "UsernameBox";
        UsernameBox.Size = new Size(200, 23);
        UsernameBox.TabIndex = 2;
        UsernameBox.TextChanged += UsernameBox_TextChanged;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(23, 55);
        label2.Name = "label2";
        label2.Size = new Size(50, 15);
        label2.TabIndex = 2;
        label2.Text = "Identity:";
        // 
        // ServerBox
        // 
        ServerBox.Enabled = false;
        ServerBox.Location = new Point(177, 23);
        ServerBox.Name = "ServerBox";
        ServerBox.ReadOnly = true;
        ServerBox.Size = new Size(166, 23);
        ServerBox.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(23, 26);
        label1.Name = "label1";
        label1.Size = new Size(42, 15);
        label1.TabIndex = 0;
        label1.Text = "Server:";
        // 
        // LoginForm
        // 
        AcceptButton = LoginButton;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = AbortButton;
        ClientSize = new Size(400, 285);
        Controls.Add(tableLayoutPanel1);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "LoginForm";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Login";
        Load += LoginForm_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        tableLayoutPanel1.ResumeLayout(false);
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private PictureBox pictureBox1;
    private TableLayoutPanel tableLayoutPanel1;
    private Panel panel1;
    private TextBox UsernameBox;
    private Label label2;
    private TextBox PasswordBox;
    private Label label1;
    private PictureBox pictureBox2;
    private Label StatusLabel;
    private TextBox ServerBox;
    private Label label3;
    private Button SwitchServerButton;
    private Button AbortButton;
    private Button LoginButton;
    private Button LogoutButton;
}