namespace IntruderFPSTool.API.Objects
{
    public class SteamProfile
    {
        public long SteamId { get; init; }
        public string Name { get; init; } = "";
        public string? AvatarUrl { get; init; }
    }
}
