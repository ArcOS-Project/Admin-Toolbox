namespace ReArc.Gui.User
{
    partial class ChangeEmailForm
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
            OldEmailField = new TextBox();
            label2 = new Label();
            NewEmailField = new TextBox();
            label3 = new Label();
            ChangeButton = new Button();
            AbortButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Icons.mail32;
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
            label1.Margin = new Padding(0, 0, 0, 10);
            label1.Name = "label1";
            label1.Size = new Size(313, 48);
            label1.TabIndex = 1;
            label1.Text = "Please enter a new email for this account. Emails applied by administrators don't have to be verified. Email addresses are unique.";
            // 
            // OldEmailField
            // 
            OldEmailField.Enabled = false;
            OldEmailField.Location = new Point(154, 84);
            OldEmailField.Name = "OldEmailField";
            OldEmailField.Size = new Size(221, 23);
            OldEmailField.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 87);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 3;
            label2.Text = "Old:";
            // 
            // NewEmailField
            // 
            NewEmailField.Location = new Point(154, 113);
            NewEmailField.Margin = new Padding(0, 0, 0, 15);
            NewEmailField.Name = "NewEmailField";
            NewEmailField.Size = new Size(221, 23);
            NewEmailField.TabIndex = 4;
            NewEmailField.TextChanged += NewEmailField_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 116);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 5;
            label3.Text = "New:";
            // 
            // ChangeButton
            // 
            ChangeButton.Enabled = false;
            ChangeButton.Location = new Point(303, 154);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(75, 23);
            ChangeButton.TabIndex = 6;
            ChangeButton.Text = "Change";
            ChangeButton.UseVisualStyleBackColor = true;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // AbortButton
            // 
            AbortButton.Location = new Point(219, 154);
            AbortButton.Name = "AbortButton";
            AbortButton.Size = new Size(75, 23);
            AbortButton.TabIndex = 7;
            AbortButton.Text = "Cancel";
            AbortButton.UseVisualStyleBackColor = true;
            AbortButton.Click += AbortButton_Click;
            // 
            // ChangeEmailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 200);
            Controls.Add(AbortButton);
            Controls.Add(ChangeButton);
            Controls.Add(label3);
            Controls.Add(NewEmailField);
            Controls.Add(label2);
            Controls.Add(OldEmailField);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChangeEmailForm";
            Padding = new Padding(20);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Change email for username";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox OldEmailField;
        private Label label2;
        private TextBox NewEmailField;
        private Label label3;
        private Button ChangeButton;
        private Button AbortButton;
    }
}