using IntruderFPSTool.API.Objects;

namespace IntruderFPSTool.API.Rest
{
    public class GetAgents : APIRequest<IReadOnlyList<Agent>>
    {
        public override string Path => $"/rooms/{RoomId}/agents";
        public int RoomId { get; init; }

        public GetAgents(int roomId)
        {
            RoomId = roomId;
        }
    }
}
