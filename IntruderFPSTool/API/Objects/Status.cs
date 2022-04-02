namespace IntruderFPSTool.API.Objects
{
    public class Status
    {
        public int Id { get; init; }
        public int AgentId { get; init; }
        public int? RoomId { get; init; }
        public DateTime LastUpdate { get; init; }
        public bool Online { get; init; }
        public Room? Room { get; init; }
    }
}
