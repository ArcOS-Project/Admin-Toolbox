namespace ReArc.Gui.Common
{
    public partial class CopyDialog : Form
    {
        public CopyDialog(string content)
        {
            InitializeComponent();

            ContentBox.Text = content;
            ContentBox.SelectAll();
            ContentBox.Copy();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static CopyDialog ShowCopyDialog(Form invocator, string content)
        {
            var dialog = new CopyDialog(content);
            invocator.BeginInvoke(() => dialog.ShowDialog(invocator));

            return dialog;
        }
    }
}
