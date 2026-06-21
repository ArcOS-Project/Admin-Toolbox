using ReArc.Gui.Views;

namespace ReArc.Gui.Common
{
    public static class PageStore
    {
        public record ToolboxPage
        {
            public required string Name { get; set; }
            public required Func<Page> Page { get; set; }
            public required Image? Image { get; set; }
            public bool? Separator;
        }

        public readonly static List<ToolboxPage> Pages =
        [
            new()
            {
                Name = "Dashboard",
                Image = Properties.Icons.dashboard,
                Page = () => new Home()
            },
            new()
            {
                Name = "Bug Reports",
                Image = Properties.Icons.bug,
                Page = () => new BugReports(),
                Separator = true
            },
            new()
            {
                Name = "Users",
                Image = Properties.Icons.users,
                Page = () => new Users(),
                Separator = true
            },
            new()
            {
                Name = "Shares",
                Image = Properties.Icons.share,
                Page = () => new Shares()
            },
            new()
            {
                Name = "Filesystems",
                Image = Properties.Icons.userfs,
                Page = () => new Filesystems()
            },
            new()
            {
                Name = "Accessors",
                Image = Properties.Icons.direction,
                Page = () => new Accessors()
            },
            new()
            {
                Name = "App Store",
                Image = Properties.Icons.appstore,
                Page = () => new Users(),
                Separator = true
            },
            new()
            {
                Name = "Tokens",
                Image = Properties.Icons.tokens,
                Page = () => new Users()
            },
            new()
            {
                Name = "Activities",
                Image = Properties.Icons.padlock,
                Page = () => new Users()
            },
            new()
            {
                Name = "Scopes",
                Image = Properties.Icons.administrator,
                Page = () => new Users(),
                Separator = true
            },
            new()
            {
                Name = "Audit Log",
                Image = Properties.Icons.audit,
                Page = () => new Users()
            },
            new()
            {
                Name = "Logs",
                Image = Properties.Icons.logs,
                Page = () => new Users()
            }
        ];
    }
}
