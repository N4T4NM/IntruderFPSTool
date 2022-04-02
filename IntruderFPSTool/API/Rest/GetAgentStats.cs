using IntruderFPSTool.API.Objects;

namespace IntruderFPSTool.API.Rest
{
    public class GetAgentStats : APIRequest<Stats>
    {
        public override string Path => $"/agents/{SteamId}/stats";
        public long SteamId { get; init; }

        public GetAgentStats(long steamId)
        {
            SteamId = steamId;
        }
    }
}
