namespace CFBRanker_API.Service.RankingAlgo
{
    public class RankedSeason
    {
        public List<List<WeightedTeam>> Weeks { get; set; } = new();
    }
}
