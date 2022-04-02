using IntruderFPSTool.API.Objects;
using IntruderFPSTool.Utils;

namespace IntruderFPSTool.UI
{
    public class RoomListViewItem : ListViewItem
    {
        public Room Room { get; private set; } = new();
        public RoomListViewItem(Room room)
        {
            UpdateInfo(room);
            RoomsView.RoomsList.OnRoomUpdated += OnUpdated;
            RoomsView.RoomsList.OnRoomRemoved += OnRemoved;
        }

        public void UpdateInfo(Room room)
        {
            Room = room;

            this.SubItems.Clear();
            this.Text = Room.Name.RemoveTags();
            if (Room.Password != null)
                this.Text += "***";

            Color color =
                Room.AgentCount == 0 ? Color.DarkGray :
                Room.AgentCount == Room.MaxAgents ? Color.Red : Color.DarkGreen;

            this.ForeColor = color;

            this.SubItems.Add(Room.CurrentMap.Name);
            this.SubItems.Add(Room.Style);
            this.SubItems.Add($"{Room.AgentCount}/{Room.MaxAgents}");
            this.SubItems.Add(Room.Region);
        }

        private void OnUpdated(int id, Room room)
        {
            if (id == Room.Id)
                UpdateInfo(room);
        }
        private void OnRemoved(int id, Room room)
        {
            if (id != Room.Id) return;

            RoomsView.RoomsList.OnRoomUpdated -= OnUpdated;
            RoomsView.RoomsList.OnRoomRemoved -= OnRemoved;

            ListView.Items.Remove(this);
        }
    }
}
