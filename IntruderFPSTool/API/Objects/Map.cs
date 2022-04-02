namespace IntruderFPSTool.API.Objects
{
    public class Map
    {
        public long Id { get; init; }
        public SteamProfile Author { get; init; } = new();
        public string? Name { get; init; }
        public string? Gamemode { get; init; }
        public string? ThumbnailUrl { get; init; }
        public bool IsMapMakerMap { get; init; }
        public IReadOnlyList<string>? Tags { get; init; }
        public DateTime LastUpdate { get; init; }
    }
}
