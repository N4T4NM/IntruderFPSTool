namespace IntruderFPSTool.API.Objects
{
    public class Room
    {
        public int Id { get; init; }
        public string Name { get; init; } = "";
        public string? Motd { get; init; }
        public string? Password { get; init; }
        public string Region { get; init; } = "";
        public bool Official { get; init; }
        public bool Ranked { get; init; }
        public string? Style { get; init; }
        public int Version { get; init; }
        public int Position { get; init; }
        public IReadOnlyList<SetScore>? Scores { get; init; } //TODO: Change this 
        public Map CurrentMap { get; init; } = new();
        public IReadOnlyList<Map> Maps { get; init; } = new List<Map>();
        public int MaxAgents { get; init; }
        public int AgentCount { get; init; }
        public int SpectatorSlots { get; init; }
        public string JoinableBy { get; init; } = "";
        public object? Blacklist { get; init; } //TODO: Change this
        public int CreatorId { get; init; }
        public object Rules { get; init; } = new(); //TODO: Change this
        public object? Tuning { get; init; } //TODO: Change this
        public DateTime LastUpdate { get; init; }
        public Agent Creator { get; init; }
    }
}
