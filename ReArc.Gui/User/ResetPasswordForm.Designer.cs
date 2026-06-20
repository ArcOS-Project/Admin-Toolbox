namespace ReArc.Gui.User
{
    partial class ResetPasswordForm
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
            GeneratedRadioButton = new RadioButton();
            ManualRadioButton = new RadioButton();
            NewPasswordBox = new TextBox();
            ResetButton = new Button();
            AbortButton = new Button();
            CopyButton = new Button();
            RegenerateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Icons.password32;
            pictureBox1.Location = new Point(23, 23);
            pictureBox1.Margin = new Padding(0, 0, 10, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Location = new Point(65, 23);
            label1.Margin = new Padding(0, 0, 0, 15);
            label1.Name = "label1";
            label1.Size = new Size(313, 48);
            label1.TabIndex = 1;
            label1.Text = "Please choose a new password for this user. You MUST copy the password in order to be allowed to save the changes. Send the new password to the user.";
            // 
            // GeneratedRadioButton
            // 
            GeneratedRadioButton.AutoSize = true;
            GeneratedRadioButton.Checked = true;
            GeneratedRadioButton.Location = new Point(65, 89);
            GeneratedRadioButton.Margin = new Padding(0);
            GeneratedRadioButton.Name = "GeneratedRadioButton";
            GeneratedRadioButton.Size = new Size(147, 19);
            GeneratedRadioButton.TabIndex = 2;
            GeneratedRadioButton.TabStop = true;
            GeneratedRadioButton.Text = "Generate automatically";
            GeneratedRadioButton.UseVisualStyleBackColor = true;
            GeneratedRadioButton.CheckedChanged += ManualRadioButton_CheckedChanged;
            // 
            // ManualRadioButton
            // 
            ManualRadioButton.AutoSize = true;
            ManualRadioButton.Location = new Point(65, 114);
            ManualRadioButton.Margin = new Padding(0, 0, 0, 10);
            ManualRadioButton.Name = "ManualRadioButton";
            ManualRadioButton.Size = new Size(107, 19);
            ManualRadioButton.TabIndex = 3;
            ManualRadioButton.TabStop = true;
            ManualRadioButton.Text = "Enter manually:";
            ManualRadioButton.UseVisualStyleBackColor = true;
            ManualRadioButton.CheckedChanged += ManualRadioButton_CheckedChanged;
            // 
            // NewPasswordBox
            // 
            NewPasswordBox.Location = new Point(65, 143);
            NewPasswordBox.Margin = new Padding(0, 0, 0, 10);
            NewPasswordBox.Name = "NewPasswordBox";
            NewPasswordBox.ReadOnly = true;
            NewPasswordBox.Size = new Size(313, 23);
            NewPasswordBox.TabIndex = 4;
            NewPasswordBox.TextChanged += NewPasswordBox_TextChanged;
            // 
            // ResetButton
            // 
            ResetButton.Enabled = false;
            ResetButton.Location = new Point(303, 179);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(75, 23);
            ResetButton.TabIndex = 5;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // AbortButton
            // 
            AbortButton.Location = new Point(222, 179);
            AbortButton.Name = "AbortButton";
            AbortButton.Size = new Size(75, 23);
            AbortButton.TabIndex = 6;
            AbortButton.Text = "Cancel";
            AbortButton.UseVisualStyleBackColor = true;
            AbortButton.Click += AbortButton_Click;
            // 
            // CopyButton
            // 
            CopyButton.Enabled = false;
            CopyButton.Location = new Point(65, 179);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(75, 23);
            CopyButton.TabIndex = 7;
            CopyButton.Text = "Copy";
            CopyButton.UseVisualStyleBackColor = true;
            CopyButton.Click += CopyButton_Click;
            // 
            // RegenerateButton
            // 
            RegenerateButton.Location = new Point(303, 87);
            RegenerateButton.Name = "RegenerateButton";
            RegenerateButton.Size = new Size(75, 23);
            RegenerateButton.TabIndex = 8;
            RegenerateButton.Text = "Regenerate";
            RegenerateButton.UseVisualStyleBackColor = true;
            RegenerateButton.Click += RegenerateButton_Click;
            // 
            // ResetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 223);
            Controls.Add(RegenerateButton);
            Controls.Add(CopyButton);
            Controls.Add(AbortButton);
            Controls.Add(ResetButton);
            Controls.Add(NewPasswordBox);
            Controls.Add(ManualRadioButton);
            Controls.Add(GeneratedRadioButton);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ResetPasswordForm";
            Padding = new Padding(20);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Reset password for username";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private RadioButton GeneratedRadioButton;
        private RadioButton ManualRadioButton;
        private TextBox NewPasswordBox;
        private Button ResetButton;
        private Button AbortButton;
        private Button CopyButton;
        private Button RegenerateButton;
    }
}