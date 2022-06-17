using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace App.Filters
{
    public class DayActionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var param = context.ActionArguments.SingleOrDefault(p => p.Value is int);

            if (param.Value == null || (int)param.Value < 0)
            {
                context.Result = new BadRequestObjectResult("Input não pode ser menor que 0");
                return;
            }
        }
    }
}