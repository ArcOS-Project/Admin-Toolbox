using Org.BouncyCastle.Asn1.X509;
using ReArc.ApiHandler.Controllers;
using ReArc.Gui.Components;
using ReArc.Shared;
using ReArc.Shared.Records.Database;
using ReArc.Shared.Records.Responses;

namespace ReArc.Gui.Views
{
    public partial class Accessors : Page
    {
        private List<ArcUser> _users = [];
        private List<FsAccess> _accessors = [];

        public Accessors()
        {
            InitializeComponent();
        }

        public override async Task<CommandResult<bool>> LoadData(Dictionary<string, object>? props = null)
        {
            var usersResponse = await AdminController.GetAllUsers();
            if (!usersResponse.Success) return CommandResult<bool>.Error(usersResponse.ErrorMessage);

            var accessorsResponse = await AdminController.GetAllAccessors();
            if (!accessorsResponse.Success) return CommandResult<bool>.Error(accessorsResponse.ErrorMessage);

            _users = usersResponse.Result!;
            _accessors = accessorsResponse.Result!;
            return CommandResult<bool>.Ok(true);
        }

        public override void Render()
        {
            MainForm!.BeginInvoke(() =>
            {
                var accessorsList = new AccessorsList()
                {
                    Dock = DockStyle.Fill,
                    Users = _users,
                    Items = _accessors,
                    MainForm = MainForm
                };

                Controls.Add(accessorsList);
                accessorsList.PopulateList();
            });
        }
    }
}
