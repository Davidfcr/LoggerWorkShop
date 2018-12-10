namespace LoggerElasticSearch.Controllers
{
    #region using
    using Microsoft.AspNetCore.Mvc;
    #endregion

    [Route("api/[controller]")]
    public class PingController : Controller
    {
        //GET api/Ping
        public IActionResult Index()
        {
            return Ok("Pong !!");
        }

        //GET api/Ping/values?value1=2&value2=2
        [HttpGet("{value1:int}/{value2:int}")]
        public IActionResult PingVals(int value1, int value2)
        {
            try
            {
                int div = value1 / value2;
                return Ok($"Hit a {div} Pongs !!");
            }
            catch (System.Exception ex)
            {
                return Ok($"Didn't hit a Pong because {ex.Message}");
            }
        }
    }
}