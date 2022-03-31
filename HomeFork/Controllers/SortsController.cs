using Microsoft.AspNetCore.Mvc;

namespace HomeFork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SortsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> DownloadResult(int[] nums)
        {
            return "value";
        }

        [HttpPost]
        public void Sort([FromBody] string value)
        {
        }
    }
}
