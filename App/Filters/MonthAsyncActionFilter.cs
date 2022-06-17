using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace App.Filters
{
    public class MonthAsyncActionFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var param = context.ActionArguments.SingleOrDefault(p => p.Value is int);

            if (param.Value == null || (int)param.Value < 0 || (int)param.Value > 11)
            {
                context.Result = new BadRequestObjectResult("Input não pode ser menor que 0 nem maior que 11");
                return;
            }

            var result = await next();
        }
    }
}
