using HomeFork.Helpers;
using HomeFork.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace HomeFork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SortsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<SortingResult>> DownloadResult()
        {
            return FileManager.Load();
        }

        [HttpPost]
        public IActionResult Sort([FromBody] int[] numbers)
        {
            var result = new List<SortingResult>();

            var watch = Stopwatch.StartNew();
            var sortedByBubbles = SortingManager.SortWithBubbles(numbers);
            watch.Stop();
            result.Add(new SortingResult()
            {
                Sorted = sortedByBubbles,
                Algorithm = "Bubbles!",
                Time = watch.Elapsed.TotalMilliseconds
            });

            watch.Restart();
            var sortedViaMerge = SortingManager.DoDatMergeSort(numbers);
            watch.Stop();
            result.Add(new SortingResult()
            {
                Sorted = sortedViaMerge,
                Algorithm = "Merge sort",
                Time = watch.Elapsed.TotalMilliseconds
            });

            FileManager.Save(result);

            return Ok(result);
        }
    }
}
