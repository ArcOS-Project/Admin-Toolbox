using ReArc.Gui.Helpers;
using ReArc.Shared.Helpers;
using ReArc.Shared.Records.Database;
using ReArc.Shared.Records.Responses.User;

namespace ReArc.Gui.Components
{
    public partial class FilesystemsList : BaseList<ArcUser>
    {
        public required Dictionary<string, UserQuota> QuotaOverview;
        protected override List<string> FilterOptions() => ["All", "Normal size", "Abnormal size", "Below 75%", "Above 75%"];
        protected override List<DataGridViewColumn> Columns()
        {
            return [
                TableHelpers.ImageColumn(Properties.Icons.share, "Icon"),
                TableHelpers.TextColumn("Username", "Username", DataGridViewAutoSizeColumnMode.Fill),
                TableHelpers.TextColumn("Used", "Used"),
                TableHelpers.TextColumn("Free", "Free"),
                TableHelpers.TextColumn("Total", "Total"),
                TableHelpers.TextColumn("Percentage", "%"),
                TableHelpers.ImageColumn(Properties.Icons.indexing, "Index", "Index filesystem"),
            ];
        }

        protected override bool QueryFilterCallback(string query, ArcUser item)
        {
            var comparison = StringComparison.InvariantCultureIgnoreCase;

            return query == string.Empty ||
                   item.Username.Contains(query, comparison) ||
                   item.Email.Contains(query, comparison) ||
                   item._id == query;
        }

        protected override bool FilterCallback(string filter, ArcUser item)
        {
            var quota = QuotaOverview.TryGetValue(item.Username, out UserQuota? value) ? value : null;

            if (quota == null) return true;

            return filter switch
            {
                "All" => true,
                "Normal size" => quota.Max == Math.Pow(1024, 3),
                "Abnormal size" => quota.Max != Math.Pow(1024, 3),
                "Below 75%" => quota.Percentage < 75,
                "Above 75%" => quota.Percentage > 75,
                _ => true
            };
        }

        protected override object[] GetGridRow(ArcUser item)
        {
            var quota = QuotaOverview.TryGetValue(item.Username, out UserQuota? value) ? value : null;

            return
            [
                Properties.Icons.user,
                item.Username,
                quota != null ? ByteHelpers.FormatBytes(quota.Used) : "",
                quota != null ? ByteHelpers.FormatBytes(quota.Free) : "",
                quota != null ? ByteHelpers.FormatBytes(quota.Max) : "",
                $"{quota?.Percentage ?? 0:F2}%",
                Properties.Icons.indexing
            ];
        }

        protected override void OnCellClicked(string columnName, ArcUser item, int row, int column)
        {
            switch (columnName)
            {
                case "Index":
                    MessageBox.Show("Not implemented");
                    break;
            }
        }

        public static void Create(MainForm MainForm, Control target, List<ArcUser> users, Dictionary<string, UserQuota> quotaOverview)
        {
            MainForm.BeginInvoke(() =>
            {
                var filesystemsList = new FilesystemsList()
                {
                    Dock = DockStyle.Fill,
                    QuotaOverview = quotaOverview,
                    MainForm = MainForm,
                    Items = users
                };

                target.Controls.Add(filesystemsList);
                filesystemsList.PopulateList();
            });
        }
    }
}
