using IntruderFPSTool.API.Objects;
using System.Text.Json.Serialization;

namespace IntruderFPSTool.API.Rest
{
    public class GetRooms : APIRequest<FoundRooms>
    {
        public override string Path => "/rooms";

        [UrlParameter(Name = "Q")]
        public string? NameFilter { get; set; }

        [UrlParameter]
        public int? Version { get; set; } = null;

        [UrlParameter]
        public string? Region { get; set; }

        [UrlParameter]
        public bool? HideEmpty { get; set; } = null;

        [UrlParameter]
        public bool? HideFull { get; set; } = null;

        [UrlParameter]
        public bool? HidePassworded { get; set; } = null;

        [UrlParameter]
        public bool? HideOfficial { get; set; } = null;

        [UrlParameter]
        public bool? HideCustom { get; set; } = null;

        [UrlParameter]
        public bool? HideUnranked { get; set; } = null;

        [UrlParameter]
        public int? Page { get; set; } = null;

        [UrlParameter]
        public int? PerPage { get; set; } = null;
    }

    public class FoundRooms
    {
        public int TotalCount { get; init; }

        [JsonPropertyName("data")]
        public IReadOnlyList<Room> Rooms { get; init; } = new List<Room>();
    }
}
