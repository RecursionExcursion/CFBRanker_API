using CFB_Ranker.Persistence;
using CFB_Ranker.Persistence.Serialization;
using CFBRanker_API.Service;
using CFBRanker_API.Service.RankingAlgo;
using Microsoft.AspNetCore.Mvc;

namespace CFBRanker_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CFBRController : ControllerBase
    {

        private readonly CfbrService _service;

        public CFBRController()
        {
            _service = new();
        }

        [HttpGet]
        public IActionResult GetTeamsDefault()
        {
            RankedSeason teams = _service.GetTeamsDefault();
            return Ok(teams);
        }
    }
}
