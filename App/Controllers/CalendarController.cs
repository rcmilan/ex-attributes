using App.Filters;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalendarController : ControllerBase
    {
        [HttpGet("Day")]
        [ServiceFilter(typeof(DayActionFilter))]
        public int GetDay(int addDays)
        {
            return DateTime.Now.AddDays(addDays).Day;
        }

        [HttpGet("Month")]
        [ServiceFilter(typeof(MonthAsyncActionFilter))]
        public int GetMonth(int addMonths)
        {
            return DateTime.Now.AddDays(addMonths).Month;
        }
    }
}
