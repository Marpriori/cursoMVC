using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Treinamento_Benner.Filters
{
    public class LogActionFilter: ActionFilterAttribute
    {

        private static void Log(RouteData routeData, /*[CallerMemberName]*/string methodName = "")
        {
            var controllerName = routeData.Values["Controller"];
            var actionName = routeData.Values["Action"];
            var message = string.Format("{0} controller: {1} action: {2}", methodName, controllerName, actionName);
            Debug.WriteLine(message, "Action Filter Log");
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
           // base.OnActionExecuted(filterContext);
            Log(filterContext.RouteData, "OnActionExecuted");
        }
        
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
          //  base.OnActionExecuting(filterContext);
            Log(filterContext.RouteData, "OnActionExecuting");
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
           // base.OnResultExecuted(filterContext);
            Log(filterContext.RouteData, "OnResultExecuted");
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
          //  base.OnResultExecuting(filterContext);
            Log(filterContext.RouteData, "OnResultExecuting");
        }
    }
}