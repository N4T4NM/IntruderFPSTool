using IntruderFPSTool.API;
using IntruderFPSTool.API.Objects;
using IntruderFPSTool.API.Rest;
using IntruderFPSTool.Utils;
using System.Diagnostics;

namespace IntruderFPSTool.UI
{
    public partial class RoomInfoView : UserControl
    {
        public delegate void OnRoomUpdateEvent(Room room, bool success);
        public event OnRoomUpdateEvent? RoomUpdated;

        public RoomInfoView()
        {
            InitializeComponent();
        }

        public Room? Room { get; private set; }
        public RoomInfoView(Room room)
        {
            InitializeComponent();
            Room = room;
        }

        private void RoomInfoView_Load(object sender, EventArgs e) => UpdateRoom();

        private void backButton_Click(object sender, EventArgs e) => GoBack();

        private void updateRoom_Click(object sender, EventArgs e) => UpdateRoom();

        public void UpdateRoom()
        {
            this.Enabled = false;
            this.DispatchAsyncTask(UpdateRoomAsync(), OnRoomUpdated);
        }

        async Task<APIResponse<Room>> UpdateRoomAsync()
        {
            APIResponse<Room> response = await new GetRoom(Room!.Id).SendAsync();
            return response;
        }

        private void OnRoomUpdated(APIResponse<Room> value)
        {
            this.Enabled = true;
            if (!value.Success)
            {
                RoomUpdated?.Invoke(Room!, false);
                GoBack();
                return;
            }

            Room = value.Response!;
            SetRoomData();
            RoomUpdated?.Invoke(Room, true);
        }

        void SetRoomData()
        {
            roomName.Text = Room!.Name.RemoveTags();
            roomId.Text = $"Id: {Room!.Id}";
            roomMotd.Text = $"Motd: {Room!.Motd}";
            roomHasPassword.Text = $"Has Password: {Room!.Password != null}";
            roomRegion.Text = $"Region: {Room!.Region}";
            roomIsOfficial.Text = $"Official: {Room!.Official}";
            roomIsRanked.Text = $"Ranked: {Room!.Ranked}";
            roomStyle.Text = $"Style: {Room!.Style}";
            roomJoinableBy.Text = $"Joinable By: {Room!.JoinableBy}";
            roomCreator.Text = $"Creator: {Room!.Creator.Name}";

            roomOverview.Text = $"Map: {Room!.CurrentMap.Name} | Players: {Room!.AgentCount}/{Room!.MaxAgents}";
        }

        void GoBack()
        {
            MainForm.Instance.SetControl(RoomsView.Instance);
            this.Dispose();
        }

        private void roomMatchInfoLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MatchInfoView view = new(this);
            MainForm.Instance.SetControl(view);
        }

        private void joinLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => Process.Start("cmd", $"/C start \"\" \"steam://rungameid/518150//join {Room!.Id}/\"");
    }
}
