using ReArc.Gui.Helpers;
using ReArc.Shared.Records.Database;
using ReArc.Shared.Records.Responses;

namespace ReArc.Gui.Components
{
    public partial class BugReportList : BaseList<BugReport>
    {
        public List<ArcUser> Users = [];
        protected override List<string> FilterOptions() => ["All", "System", "Apps", "Opened", "Closed", "With user data", "No user data"];
        protected override List<DataGridViewColumn> Columns()
        {
            return [
                TableHelpers.ImageColumn(Properties.Icons.user, "Icon"),
                TableHelpers.TextColumn("Timestamp", "Timestamp"),
                TableHelpers.TextColumn("Title", "Title", DataGridViewAutoSizeColumnMode.Fill),
                TableHelpers.TextColumn("Author", "Author"),
                TableHelpers.CheckboxColumn("Opened", "Opened"),
                TableHelpers.CheckboxColumn("UserData", "User Data?"),
                TableHelpers.ImageColumn(Properties.Icons.eye, "View", "View"),
            ];
        }

        protected override bool QueryFilterCallback(string query, BugReport item)
        {
            var comparison = StringComparison.InvariantCultureIgnoreCase;

            return query == string.Empty ||
                   (item.Body?.Contains(query, comparison) ?? false) ||
                   (item.Title?.Contains(query, comparison) ?? false) ||
                   (item.UserAgent?.Contains(query, comparison) ?? false) ||
                   item._id == query;
        }

        protected override void OnCellClicked(string columnName, BugReport item, int row, int column)
        {
            switch (columnName)
            {
                case "View":
                    MessageBox.Show("Not implemented");
                    break;
            }
        }

        protected override bool FilterCallback(string filter, BugReport item)
        {
            return filter switch
            {
                "All" => true,
                "System" => item.IsAppReport != true,
                "Apps" => item.IsAppReport == true,
                "Closed" => item.Closed,
                "Opened" => !item.Closed,
                "With user data" => item.UserData != null,
                "No user data" => item.UserData == null,
                _ => true
            };
        }

        protected override object[] GetGridRow(BugReport item)
        {
            var createdDate = DateTime.Parse(item.CreatedAt).ToString("dd-MM-yyyy, HH:mm:ss");
            var author = Users.Find((u) => u._id == item.AuthorId)?.Username ?? "Stranger";

            return [Properties.Icons.bug, createdDate, item.Title, author, !item.Closed, item.UserData != null];
        }

        public static void Create(MainForm MainForm, Control target, List<ArcUser> users, List<BugReport> reports)
        {
            MainForm.BeginInvoke(() =>
            {
                var reportsList = new BugReportList()
                {
                    Dock = DockStyle.Fill,
                    Users = users,
                    MainForm = MainForm,
                    Items = reports
                };

                target.Controls.Add(reportsList);
                reportsList.PopulateList();
            });
        }
    }
}
