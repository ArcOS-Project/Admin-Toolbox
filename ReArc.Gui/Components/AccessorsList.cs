using ReArc.Gui.Helpers;
using ReArc.Shared.Records.Database;
using ReArc.Shared.Records.Responses;

namespace ReArc.Gui.Components
{
    public partial class AccessorsList : BaseList<FsAccess>
    {
        public List<ArcUser> Users = [];

        protected override List<string> FilterOptions() => ["All"];
        protected override List<DataGridViewColumn> Columns()
        {
            return [
                TableHelpers.ImageColumn(Properties.Icons.direction, "Icon"),
                TableHelpers.TextColumn("Timestamp", "Timestamp"),
                TableHelpers.TextColumn("Path", "Path", DataGridViewAutoSizeColumnMode.Fill),
                TableHelpers.TextColumn("Accessor", "Accessor"),
                TableHelpers.TextColumn("Author", "Author"),
            ];
        }

        protected override bool QueryFilterCallback(string query, FsAccess item)
        {
            var comparison = StringComparison.InvariantCultureIgnoreCase;

            return query == string.Empty ||
                   (item.Path?.Contains(query, comparison) ?? false) ||
                   (item.UserId?.Contains(query, comparison) ?? false) ||
                   (item.Accessor?.Contains(query, comparison) ?? false) ||
                   item._id == query;
        }

        protected override bool FilterCallback(string filter, FsAccess item)
        {
            return filter switch
            {
                "All" => true,
                _ => true
            };
        }

        protected override object[] GetGridRow(FsAccess item)
        {
            var createdDate = DateTime.Parse(item.CreatedAt).ToString("dd-MM-yyyy, HH:mm:ss");
            var author = Users.Find((u) => u._id == item.UserId)?.Username ?? "Stranger";

            return [Properties.Icons.direction, createdDate, item.Path, item.Accessor, author];
        }

        public static void Create(MainForm MainForm, Control target, List<ArcUser> users, List<FsAccess> reports)
        {
            MainForm.BeginInvoke(() =>
            {
                var reportsList = new AccessorsList()
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
