using ReArc.Gui.Common;
using ReArc.Gui.Helpers;
using ReArc.Gui.Views;
using ReArc.Shared.Helpers;
using ReArc.Shared.Records.Database;
using ReArc.Shared.Records.Responses;

namespace ReArc.Gui.Components
{
    public partial class ShareList : BaseList<SharedDrive>
    {
        protected override List<string> FilterOptions() => ["All", "Not locked", "Locked", "Abnormal size", "Normal size", "No members", "Has members"];
        public List<ArcUser> Users = [];

        protected override List<DataGridViewColumn> Columns()
        {
            return [
                TableHelpers.ImageColumn(Properties.Icons.share,"ProfilePicture"),
                TableHelpers.TextColumn("Name","Share name", DataGridViewAutoSizeColumnMode.Fill),
                TableHelpers.TextColumn("Owner","Owner"),
                TableHelpers.TextColumn("Members","Members"),
                TableHelpers.TextColumn("Size","Size"),
                TableHelpers.CheckboxColumn("Locked","Locked")
            ];
        }

        protected override bool QueryFilterCallback(string query, SharedDrive item)
        {
            var comparison = StringComparison.InvariantCultureIgnoreCase;

            return query == string.Empty ||
                   (item.Description?.Contains(query, comparison) ?? false) ||
                   (item.ShareName?.Contains(query, comparison) ?? false) ||
                   item._id == query;
        }

        protected override bool FilterCallback(string filter, SharedDrive item)
        {
            return filter switch
            {
                "All" => true,
                "Not locked" => item.Locked != true,
                "Locked" => item.Locked == true,
                "Abnormal size" => item.MaxSize != Math.Pow(1024, 3) / 2,
                "Normal size" => item.MaxSize == Math.Pow(1024, 3) / 2,
                "No members" => item.Accessors.Length == 0,
                "Has members" => item.Accessors.Length > 0,
                _ => true
            };
        }

        protected override object[] GetGridRow(SharedDrive item)
        {
            var author = Users.Find((u) => u._id == item.UserId)?.Username ?? "Stranger";

            return ([Properties.Icons.share, item.ShareName, author, item.Accessors.Length, ByteHelpers.FormatBytes(item.MaxSize), item.Locked]);
        }

        public static void Create(MainForm MainForm, Control target, List<ArcUser> users, List<SharedDrive> shares)
        {
            MainForm.BeginInvoke(() =>
            {
                var sharesList = new ShareList()
                {
                    Dock = DockStyle.Fill,
                    Users = users,
                    MainForm = MainForm,
                    Items = shares
                };

                target.Controls.Add(sharesList);
                sharesList.PopulateList();
            });

        }
    }
}
