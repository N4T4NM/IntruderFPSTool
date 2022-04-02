using IntruderFPSTool.API.Rest;

namespace IntruderFPSTool.UI
{
    public partial class RoomsViewSettings : UserControl
    {
        public static RoomsViewSettings Instance { get; } = new();
        public GetRooms Settings { get; } = new();

        public RoomsViewSettings()
        {
            InitializeComponent();
        }

        private void RoomsViewSettings_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetControl(RoomsView.Instance);
        }

        private void nameFilter_TextChanged(object sender, EventArgs e)
        {
            Settings.NameFilter = nameFilter.Text;
            if (Settings.NameFilter.Length == 0) Settings.NameFilter = null;
        }

        private void versionInput_TextChanged(object sender, EventArgs e)
        {
            bool result = int.TryParse(versionInput.Text, out int version);
            Settings.Version = result ? version : null;
            versionInput.ForeColor = result ? Color.Black : Color.Red;
        }

        private void regionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (regionCombo.SelectedIndex < 1)
                Settings.Region = null;
            else Settings.Region = regionCombo.SelectedItem.ToString();
        }

        private void hideEmptyCheck_CheckedChanged(object sender, EventArgs e)
            => Settings.HideEmpty = hideEmptyCheck.Checked;

        private void hideFullCheck_CheckedChanged(object sender, EventArgs e)
            => Settings.HideFull = hideFullCheck.Checked;

        private void hidePasswordedCheck_CheckedChanged(object sender, EventArgs e)
            => Settings.HidePassworded = hidePasswordedCheck.Checked;

        private void hideOfficialCheck_CheckedChanged(object sender, EventArgs e)
            => Settings.HideOfficial = hideOfficialCheck.Checked;

        private void hideCustomCheck_CheckedChanged(object sender, EventArgs e)
            => Settings.HideCustom = hideCustomCheck.Checked;

        private void hideUnrankedCheck_CheckedChanged(object sender, EventArgs e)
            => Settings.HideUnranked = hideUnrankedCheck.Checked;
    }
}
