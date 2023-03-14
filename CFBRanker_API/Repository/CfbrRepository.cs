using CFB_Ranker.Persistence.Serialization;
using CFB_Ranker.Persistence;

namespace CFBRanker_API.Repository
{
    public class CfbrRepository
    {
        public Season GetTeams()
        {
            Season season = new PersistenceManager().LoadData();
            return season;
        }
    }
}
