using IntruderFPSTool.API.Objects;

namespace IntruderFPSTool.API.Rest
{
    public class GetRoom : APIRequest<Room>
    {
        public override string Path => $"/rooms/{RoomId}";
        public int RoomId { get; init; }

        public GetRoom(int roomId)
        {
            RoomId = roomId;
        }
    }
}
