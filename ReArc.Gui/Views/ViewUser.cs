using ReArc.ApiHandler;
using ReArc.ApiHandler.Controllers;
using ReArc.Gui.Common;
using ReArc.Gui.Components;
using ReArc.Gui.User;
using ReArc.Shared;
using ReArc.Shared.Helpers;
using ReArc.Shared.Records.Database;
using ReArc.Shared.Records.Responses.User;

namespace ReArc.Gui.Views
{
    public partial class ViewUser : Page
    {
        private readonly ImageList _tabImages = new();
        private List<ArcUser> _users = [];
        private UserQuota? _quota;
        private ArcUser? _user;
        private UserStatistics? _stats;
        private Totp? _totpInfo;
        private string _profilePicture = string.Empty;
        public ViewUser()
        {
            _tabImages.Images.Add(Properties.Icons.logout);
            _tabImages.Images.Add(Properties.Icons.magnifier);
            _tabImages.Images.Add(Properties.Icons.totp);
            _tabImages.Images.Add(Properties.Icons.padlock);
            InitializeComponent();
        }

        public override async Task<CommandResult<bool>> LoadData(Dictionary<string, object>? props = null)
        {
            if (props != null && props.TryGetValue("User", out var user) && user is ArcUser)
            {
                _user = user as ArcUser;

                LoadingDialog.ChangeCaption("Retrieving users");
                var usersResult = await AdminController.GetAllUsers();
                if (!usersResult.Success) return CommandResult<bool>.Error(usersResult.ErrorMessage);

                LoadingDialog.ChangeCaption("Downloading profile picture");
                var pfpResult = await UserController.DownloadProfilePicture(_user!._id);
                if (pfpResult.Success) _profilePicture = pfpResult.Result!;

                LoadingDialog.ChangeCaption("Getting filesystem quota");
                var quotaResult = await AdminController.GetQuotaOf(_user!.Username);
                if (!quotaResult.Success) return CommandResult<bool>.Error(quotaResult.ErrorMessage);

                LoadingDialog.ChangeCaption("Getting user statistics");
                var statisticsResult = await AdminController.GetStatisticsOf(_user!._id);
                if (!statisticsResult.Success) return CommandResult<bool>.Error(statisticsResult.ErrorMessage);

                LoadingDialog.ChangeCaption("Obtaining 2FA information");
                var totpResult = await AdminController.GetTotpOf(_user!.Username);
                if (totpResult.Success) _totpInfo = totpResult.Result!;

                _users = usersResult.Result!;
                _quota = quotaResult.Result!;
                _stats = statisticsResult.Result!;

                return CommandResult<bool>.Ok(true);
            }

            return CommandResult<bool>.Error("Invalid invocation");
        }

        public override void Render()
        {
            if (_profilePicture != string.Empty)
            {
                ProfilePictureBox.Image = Image.FromFile(_profilePicture);
            }

            UsernameLabel.Text = _user!.Username;
            EmailLabel.Text = _user!.Email;
            FilesystemQuotaBar.Maximum = 100;
            FilesystemQuotaBar.Value = (int)_quota!.Percentage;
            FilesystemPercentageLabel.Text = $"{_quota!.Percentage:F2}%";
            ByteUsageLabel.Text = $"{ByteHelpers.FormatBytes(_quota.Used)} / {ByteHelpers.FormatBytes(_quota.Max)}";
            UserIdLabel.Text = _user!._id;

            ActivitiesLabel.Text = _stats!.Activities.ToString();
            TokensLabel.Text = _stats!.Tokens.ToString();
            BugHuntsLabel.Text = _stats!.Bughunts.ToString();
            AccessorsLabel.Text = _stats!.Fsaccesses.ToString();
            IndexingsLabel.Text = _stats!.Indexings.ToString();
            MessagesLabel.Text = _stats!.Messages.ToString();
            SharesLabel.Text = _stats!.Shares.ToString();

            ApprovedAction.Checked = _user!.Approved;
            AdministratorAction.Checked = _user!.Admin;
            LogOutAction.Enabled = _user._id != UserController.UserInfo!._id;

            PopulateQuickSwitcher();
            QuickSwitcher.Text = _user!.Username;
            Manage2faAction.Enabled = _totpInfo != null;
        }

        private void PopulateQuickSwitcher()
        {
            QuickSwitcher.DropDownItems.Clear();

            foreach (var user in _users!)
            {
                var MenuItem = new ToolStripMenuItem()
                {
                    Text = user.Username,
                    Image = Properties.Icons.user,
                    ImageScaling = ToolStripItemImageScaling.SizeToFit
                };

                MenuItem.Click += QuickSwitchItem_Click;
                QuickSwitcher.DropDownItems.Add(MenuItem);
            }
        }

        private void QuickSwitchItem_Click(object? sender, EventArgs e)
        {
            if (sender is not ToolStripMenuItem) return;

            var username = ((ToolStripMenuItem)sender).Text;
            var user = _users.Find((u) => u.Username == username);

            if (user == null) return;

            _ = MainForm!.SwitchView(new ViewUser(), $"View {username}", new Dictionary<string, object>
            {
                {"User", user }
            });
        }

        private void ApprovedAction_Click(object sender, EventArgs e)
        {
            var approved = _user!.Approved;
            DialogResult confirm = MessageBox.Show(MainForm,
                approved
                    ? $"Are you sure you want to disapprove {_user.Username}? They won't be able to log in anymore."
                    : $"Are you sure you want to manually approve {_user.Username}?",
                approved
                    ? $"Disapprove {_user.Username}"
                    : $"Approve {_user.Username}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);

            if (confirm is DialogResult.Yes)
            {
                _ = ToggleApproved();
            }
        }

        private async Task ToggleApproved()
        {
            var approved = _user!.Approved;
            var result = approved
                ? await AdminController.DisapproveUser(_user!.Username)
                : await AdminController.ApproveUser(_user!.Username);

            if (!result.Success)
            {
                MessageBox.Show(MainForm, $"The operation did not complete successfully. {result.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ApprovedAction.Checked = !approved;
        }

        private void AdministratorAction_Click(object sender, EventArgs e)
        {
            var granted = _user!.Admin;
            DialogResult confirm = MessageBox.Show(MainForm,
                granted
                    ? $"Are you sure you want to revoke administrative privileges from {_user.Username}?"
                    : $"Are you sure you want to grant administrative privileges to {_user.Username}?",
                $"Administrative privileges for {_user.Username}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);

            if (confirm is DialogResult.Yes)
            {
                _ = ToggleAdmin();
            }
        }

        private async Task ToggleAdmin()
        {
            var granted = _user!.Admin;
            var result = granted
                ? await AdminController.RevokeAdmin(_user!.Username)
                : await AdminController.GrantAdmin(_user!.Username);

            if (!result.Success)
            {
                MessageBox.Show(MainForm, $"The operation did not complete successfully. {result.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AdministratorAction.Checked = !granted;
        }

        private async Task PopulateReportsTab()
        {
            BugReportsTab.Controls.Clear();

            MainForm!.BeginInvoke(() => LoadingDialog.ShowLoading(MainForm!, "Loading bug reports"));
            await Task.Delay(100);

            var reportResult = await AdminController.GetAllBugReports();
            await LoadingDialog.Stop();

            if (!reportResult.Success)
            {
                MessageBox.Show(MainForm, $"An error occurred while obtaining bug reports. {reportResult.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var reports = reportResult.Result!.Where((r) => r.AuthorId == _user!._id).ToList();

            BugReportList.Create(MainForm!, BugReportsTab, _users!, reports);
        }

        private async Task PopulateSharesTab()
        {
            SharesTab.Controls.Clear();

            MainForm!.BeginInvoke(() => LoadingDialog.ShowLoading(MainForm!, "Loading shares"));
            await Task.Delay(100);

            var sharesResult = await AdminController.GetSharesOf(_user!._id);
            await LoadingDialog.Stop();

            if (!sharesResult.Success)
            {
                MessageBox.Show(MainForm, $"An error occurred while obtaining shared drives. {sharesResult.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ShareList.Create(MainForm!, SharesTab, _users!, sharesResult.Result!);
        }

        private async Task DoDeleteUser()
        {
            DialogResult confirm = MessageBox.Show(
               $"Are you sure you want to permanently delete {_user!.Username} from {Client.Hostname}? This action CANNOT BE REVERTED.",
               $"Delete {_user!.Username}",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Exclamation);

            if (confirm != DialogResult.Yes) return;

            var result = await AdminController.DeleteUser(_user!.Username);

            if (!result.Success)
            {
                MessageBox.Show(MainForm, $"An error occurred while deleting this user. {result.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await MainForm!.SwitchView(new Users(), "Users");
        }

        private void TabControl_IndexChanged(object sender, EventArgs e)
        {
            switch (Tabs.SelectedIndex)
            {
                case 1: // bug reports
                    _ = PopulateReportsTab();
                    break;
                case 2: // shares
                    _ = PopulateSharesTab();
                    break;
            }
        }

        private void UsernameCopyAction_Click(object sender, EventArgs e)
        {
            CopyDialog.ShowCopyDialog(MainForm!, _user!.Username);
        }

        private void UserIdCopyAction_Click(object sender, EventArgs e)
        {
            CopyDialog.ShowCopyDialog(MainForm!, _user!._id);
        }

        private void EmailAddressCopyAction_Click(object sender, EventArgs e)
        {
            CopyDialog.ShowCopyDialog(MainForm!, _user!.Email);
        }

        private void ProfilePictureCopyAction_Click(object sender, EventArgs e)
        {
            CopyDialog.ShowCopyDialog(MainForm!, Client.CurrentClient.CreateUrl($"/user/pfp/{_user!._id}"));
        }

        private void DeleteUserAction_Click(object sender, EventArgs e)
        {
            _ = DoDeleteUser();
        }

        private void ChangeEmailAction_Click(object sender, EventArgs e)
        {
            var changeEmailForm = new ChangeEmailForm(_user!.Username, _user!.Email) { Owner = MainForm! };
            changeEmailForm.ShowDialog(MainForm!);
        }

        private void ChangePasswordAction_Click(object sender, EventArgs e)
        {
            var resetPasswordForm = new ResetPasswordForm(_user!.Username) { Owner = MainForm! };
            resetPasswordForm.ShowDialog(MainForm!);
        }

        private void Manage2faAction_Click(object sender, EventArgs e)
        {
            var manageTotpForm = new ManageTotpForm(_user!.Username, _totpInfo!) { Owner = MainForm! };
            manageTotpForm.ShowDialog(MainForm!);
        }
    }
}
