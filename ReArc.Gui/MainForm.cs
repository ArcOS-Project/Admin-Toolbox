using ReArc.ApiHandler;
using ReArc.ApiHandler.Controllers;
using ReArc.Gui.Common;
using ReArc.Gui.Logic;
using ReArc.Gui.Server;
using ReArc.Gui.Views;
using System.Reflection;
using static ReArc.Gui.Common.PageStore;

namespace ReArc.Gui
{
    public partial class MainForm : Form
    {
        private readonly List<ToolboxPage> Pages = PageStore.Pages;
        private readonly Dictionary<string, object>? Props;

        public MainForm()
        {
            InitializeComponent();
        }

        public async Task SwitchView(Page newView, string name, Dictionary<string, object>? props = null)
        {
            if (BetterPagePanel.Controls.Count > 0 && BetterPagePanel.Controls[0] is Page oldView)
            {
                BetterPagePanel.Controls.Remove(oldView);
                oldView.Dispose();
            }

            newView.Hide();
            BetterPagePanel.Controls.Add(newView);
            newView.Dock = DockStyle.Fill;
            newView.MainForm = this;
            _ = newView.Setup(name, props);
            CurrentPageLabel.Text = name;
            CurrentPageLabel.Image = Pages.Find((p) => p.Name == name)?.Image ?? Properties.Icons.page;
            PopulateSidebarItems(name);
        }

        public async Task RefreshView() {
            if (BetterPagePanel.Controls.Count > 0 && BetterPagePanel.Controls[0] is Page oldView)
            {
                await oldView.LoadData(Props ?? new Dictionary<string, object>());
                oldView.Render();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _ = SwitchView(new Home() { MainForm = this }, "Dashboard");

            UsernameButton.Text = UserController.DisplayName ?? "Stranger";
            usernameToolStripMenuItem.Text = UserController.UserInfo!.Username;
            emailToolStripMenuItem.Text = UserController.UserInfo!.Email;
            ServerLabel.Text = Client.Hostname!;
            ServerButton.Text = Client.Hostname!;
            ServerUrlItem.Text = Client.CurrentClient.ServerOption.Url!;
            VersionLabel.Text = $"v{Assembly.GetExecutingAssembly().GetName().Version}";

            if (UserController.ProfilePicture != null)
                UsernameButton.Image = Image.FromFile(UserController.ProfilePicture!);
        }

        private void PopulateSidebarItems(string? selectedPageName = null)
        {
            SideMenuStrip.Items.Clear();

            foreach (var page in Pages)
            {
                ToolStripMenuItem item = new()
                {
                    AutoSize = false,
                    Image = page.Image,
                    ImageAlign = ContentAlignment.MiddleLeft,
                    Name = $"SideMenuItem_{page.Name.Replace(" ", "")}",
                    Padding = new Padding(20),
                    Size = new Size(SideMenuStrip.Size.Width - (SideMenuStrip.Padding.All * 2), 24),
                    Text = page.Name
                };

                SideMenuStrip.Items.Add(item);

                if (selectedPageName != null && page.Name == selectedPageName)
                {
                    item.BackColor = Color.SkyBlue;
                } else
                {
                    item.Click += PageItem_Click;
                }

                if (page.Separator == true)
                {
                    SideMenuStrip.Items.Add(new ToolStripStatusLabel()
                    {
                        Text = " ",
                        Margin = new Padding(0)
                    });
                }
            }
        }

        private void PageItem_Click(object? sender, EventArgs e)
        {
            if (sender is not ToolStripMenuItem)
            {
                return;
            }

            var pageName = ((ToolStripMenuItem)sender).Text;
            var page = Pages.Find((p) => p.Name == pageName);

            if (page == null)
            {
                MessageBox.Show($"Unknown toolbox page: {pageName}", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            var instance = page.Page();
            instance.MainForm = this;

            _ = SwitchView(instance, page.Name);
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;

            _ = UserLogic.LogoutCurrentUser(this);
        }

        private void DisconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserController.Reset();
            Client.Dispose();
            Program.SetNextForm(new SelectServerForm());
            Close();
        }
    }
}
