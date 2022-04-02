namespace IntruderFPSTool.API.Objects
{
    public class Agent
    {
        public int Id { get; init; }
        public string Role { get; init; } = "";
        public int LoginCount { get; init; }
        public DateTime FirstLogin { get; init; }
        public DateTime LastLogin { get; init; }
        public DateTime LastUpdate { get; init; }
        public Stats Stats { get; init; } = new();
        public Status Status { get; init; } = new();
        public long SteamId { get; init; }
        public string Name { get; init; } = "";
        public string? AvatarUrl { get; init; }
    }
}
