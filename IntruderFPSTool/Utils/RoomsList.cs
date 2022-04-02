using IntruderFPSTool.API.Objects;

namespace IntruderFPSTool.Utils
{
    public class RoomsList
    {
        public delegate void OnRoomStateChangedDelegate(int id, Room room);

        public event OnRoomStateChangedDelegate? OnRoomAdded;
        public event OnRoomStateChangedDelegate? OnRoomRemoved;
        public event OnRoomStateChangedDelegate? OnRoomUpdated;

        Dictionary<int, Room> cache { get; } = new();
        public void UpdateRooms(IReadOnlyList<Room> rooms)
        {
            Dictionary<int, Room> remaining = cache.Clone();

            foreach (Room room in rooms)
            {
                if (!cache.ContainsKey(room.Id))
                {
                    cache.Add(room.Id, room);
                    OnRoomAdded?.Invoke(room.Id, room);
                }
                else
                {
                    remaining.Remove(room.Id);
                    cache[room.Id] = room;
                    OnRoomUpdated?.Invoke(room.Id, room);
                }
            }

            foreach (int key in remaining.Keys)
            {
                cache.Remove(key, out Room? room);
                OnRoomRemoved?.Invoke(key, room!);
            }
        }
    }
}
