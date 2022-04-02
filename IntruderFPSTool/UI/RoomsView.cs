using IntruderFPSTool.API;
using IntruderFPSTool.API.Objects;
using IntruderFPSTool.API.Rest;
using IntruderFPSTool.Utils;

namespace IntruderFPSTool.UI
{
    public partial class RoomsView : UserControl
    {
        public static RoomsView Instance { get; } = new();
        public static RoomsList RoomsList { get; } = new();
        public RoomsView()
        {
            InitializeComponent();
        }

        private void RoomsView_Load(object sender, EventArgs e)
        {
            RoomsList.OnRoomAdded += OnRoomAdded;
            UpdateRooms();
            updateTimer.Start();
        }

        private void updateRooms_Click(object sender, EventArgs e) => UpdateRooms();

        private void setRoomSettings_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetControl(RoomsViewSettings.Instance);
        }
        void SetStatus(string status) => statusLabel.Text = status;

        void UpdateRooms()
        {
            updateRooms.Enabled = false;
            updating = true;

            SetStatus("Searching rooms...");
            this.DispatchAsyncTask(UpdateRoomsAsync(), OnRoomsUpdated);
        }
        async Task<FoundRooms> UpdateRoomsAsync()
        {
            APIResponse<FoundRooms> response = await RoomsViewSettings.Instance.Settings.SendAsync();
            FoundRooms rooms = response.Response!;
            RoomsList.UpdateRooms(rooms.Rooms);
            return rooms;
        }

        void OnRoomsUpdated(FoundRooms rooms)
        {
            updateRooms.Enabled = true;
            SetStatus($"Found {rooms.TotalCount} rooms.");
            updating = false;
        }
        private void roomsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || roomsList.SelectedItems.Count != 1) return;
            RoomListViewItem itm = (RoomListViewItem)roomsList.SelectedItems[0];

            MainForm.Instance.SetControl(new RoomInfoView(itm.Room));
        }

        void OnRoomAdded(int id, Room room)
        {
            RoomListViewItem itm = new(room);
            roomsList.Items.Add(itm);
        }

        bool updating;
        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if (!updating) UpdateRooms();
        }
    }
}
