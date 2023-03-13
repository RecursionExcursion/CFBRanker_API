using CFB_Ranker.Persistence.Serialization;
using CFB_Ranker.Persistence;
using CFBRanker_API.Service.RankingAlgo;

namespace CFBRanker_API.Service
{
    public class CfbrService
    {

        public RankedSeason GetTeamsDefault()
        {
            int Wins = 6;
            int Losses = 0;
            int PointsFor = 4;
            int PointsAllowed = 4;
            int TotalOffense = 1;
            int TotalDefense = 1;
            int ScheduleStrength = 2;
            int PollInertia = 5;

            WeightDistributor weightDistributor = new(Wins, Losses, PointsFor, PointsAllowed, TotalOffense, TotalDefense, ScheduleStrength, PollInertia);

            Season season = new PersistenceManager().LoadData();

            RankingAlgorithm rankingAlgorithm = new(season, weightDistributor);
            rankingAlgorithm.RankTeams();

            return rankingAlgorithm.WeightedRankedSeason;
        }

    }
}
