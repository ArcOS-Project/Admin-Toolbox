namespace ReArc.Gui.User
{
    partial class ManageTotpForm
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
            label1 = new Label();
            label2 = new Label();
            StatusLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            SecretBox = new TextBox();
            UrlBox = new TextBox();
            RevealButton = new Button();
            DisableButton = new Button();
            DeleteButton = new Button();
            CloseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Icons.totp32;
            pictureBox1.Location = new Point(20, 20);
            pictureBox1.Margin = new Padding(0, 0, 15, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Location = new Point(67, 20);
            label1.Margin = new Padding(0, 0, 0, 15);
            label1.Name = "label1";
            label1.Size = new Size(402, 32);
            label1.TabIndex = 1;
            label1.Text = "This user has a 2FA record associated with their account. Use this dialog to manage it in the event that the user has lost access to their 2FA credentials.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(67, 67);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Status:";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.ForeColor = Color.Red;
            StatusLabel.Location = new Point(145, 67);
            StatusLabel.Margin = new Padding(0);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(61, 15);
            StatusLabel.TabIndex = 3;
            StatusLabel.Text = "Not active";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 95);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Secret";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 124);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 5;
            label4.Text = "URL";
            // 
            // SecretBox
            // 
            SecretBox.Location = new Point(145, 92);
            SecretBox.Margin = new Padding(0);
            SecretBox.Name = "SecretBox";
            SecretBox.ReadOnly = true;
            SecretBox.Size = new Size(324, 23);
            SecretBox.TabIndex = 6;
            SecretBox.UseSystemPasswordChar = true;
            // 
            // UrlBox
            // 
            UrlBox.Location = new Point(145, 121);
            UrlBox.Margin = new Padding(0, 0, 0, 20);
            UrlBox.Name = "UrlBox";
            UrlBox.ReadOnly = true;
            UrlBox.Size = new Size(324, 23);
            UrlBox.TabIndex = 7;
            UrlBox.UseSystemPasswordChar = true;
            // 
            // RevealButton
            // 
            RevealButton.Location = new Point(145, 167);
            RevealButton.Name = "RevealButton";
            RevealButton.Size = new Size(61, 23);
            RevealButton.TabIndex = 9;
            RevealButton.Text = "Reveal";
            RevealButton.UseVisualStyleBackColor = true;
            RevealButton.Click += RevealButton_Click;
            // 
            // DisableButton
            // 
            DisableButton.Enabled = false;
            DisableButton.Location = new Point(212, 167);
            DisableButton.Name = "DisableButton";
            DisableButton.Size = new Size(60, 23);
            DisableButton.TabIndex = 10;
            DisableButton.Text = "Disable";
            DisableButton.UseVisualStyleBackColor = true;
            DisableButton.Click += DisableButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(278, 167);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(58, 23);
            DeleteButton.TabIndex = 11;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(407, 167);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(62, 23);
            CloseButton.TabIndex = 12;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // ManageTotpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 213);
            Controls.Add(CloseButton);
            Controls.Add(DeleteButton);
            Controls.Add(DisableButton);
            Controls.Add(RevealButton);
            Controls.Add(UrlBox);
            Controls.Add(SecretBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(StatusLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ManageTotpForm";
            Padding = new Padding(20);
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Manage 2FA of username";
            Load += ManageTotpForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label StatusLabel;
        private Label label3;
        private Label label4;
        private TextBox SecretBox;
        private TextBox UrlBox;
        private Button RevealButton;
        private Button DisableButton;
        private Button DeleteButton;
        private Button CloseButton;
    }
}