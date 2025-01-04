using Newtonsoft.Json;
using PandaScore.NET.Entities;

namespace PandaScoreNET {
    public class TeamOpponent {
        [JsonProperty("opponent")]
        public MatchParticipantTeam Team { get; private set; }
        public OpponentType Type => OpponentType.team;
    }
}
