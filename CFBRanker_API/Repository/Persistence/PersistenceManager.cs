using CFB_Ranker.Persistence.Serialization;

namespace CFB_Ranker.Persistence
{
    public class PersistenceManager
    {
        private readonly string _filePathFromRoot = @"\Repository\Persistence\Team_Data\file.json";

        //Get Relative Root Dir of project
        private string GetRelativeDir()
        {
            string dir = Directory.GetCurrentDirectory();
            return dir;
        }

        public Season LoadData()
        {
            string completePath = GetRelativeDir() + _filePathFromRoot;
            if (!File.Exists(completePath))
            {
                Season season = new SeasonMapper().BuildSeason();
                JSONSerializer.WriteJsonToFile<Season>(completePath, season);
            }
            return JSONSerializer.ReadJsonFromFile<Season>(completePath)!;
        }
    }
}
