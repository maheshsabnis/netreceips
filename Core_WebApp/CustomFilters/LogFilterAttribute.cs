using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System.Diagnostics;

namespace Core_WebApp.CustomFilters
{
    public class LogFilterAttribute : ActionFilterAttribute
    {

        private void LogRequest(string currentState, RouteData route)
        {
            string message = $"Current State {currentState} for Exeuting Controller is {route.Values["controller"].ToString()} and Action is {route.Values["action"].ToString()}";
            Debug.WriteLine(message);
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            LogRequest("OnActionExecuting", context.RouteData);
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            LogRequest("OnActionExecuted", context.RouteData);
        }
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            LogRequest("OnResultExecuting", context.RouteData);
        }
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            LogRequest("OnResultExecuted", context.RouteData);
        }
    }
}
