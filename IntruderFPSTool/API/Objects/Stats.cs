using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntruderFPSTool.API.Objects
{
    public class Stats
    {
        public int Id { get; init; }
        public int AgentId { get; init; }
        public int MatchesWon { get; init; }
        public int MatchesLost { get; init; }
        public int RoundsLost { get; init; }
        public int RoundsTied { get; init; }
        public int RoundsWonElimination { get; init; }
        public int RoundsWonCapture { get; init; }
        public int RoundsWonHack { get; init; }
        public int RoundsWonTimer { get; init; }
        public int RoundsWonCustom { get; init; }
        public int TimePlayed { get; init; }
        public int TimePlayedDemoted { get; init; }
        public int Kills { get; init; }
        public int TeamKills { get; init; }
        public int Deaths { get; init; }
        public int Arrests { get; init; }
        public int GotArrested { get; init; }
        public int Captures { get; init; }
        public int Pickups { get; init; }
        public int NetworkHacks { get; init; }
        public int Survivals { get; init; }
        public int Suicides { get; init; }
        public int Knockdowns { get; init; }
        public int GotKnockedDown { get; init; }
        public int TeamKnockdowns { get; init; }
        public int TeamDamage { get; init; }
        public DateTime LastUpdate { get; init; }
        public int Level { get; init; }
        public int LevelXp { get; init; }
        public int LevelXpRequired { get; init; }
        public int TotalXp { get; init; }
    }
}
