using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Treinamento_Benner.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            SetCulture(Request);
            base.OnActionExecuting(filterContext);
        }

        private void SetCulture(HttpRequestBase request)
        {
            if (request == null) return;
            if (request.UserLanguages == null) return;
            if (request.UserLanguages.Length <= 0) return;

            string cultureName = request.UserLanguages[0];
            SetCulture(cultureName);
        }
        private void SetCulture(string cultureName)
        {
            Thread.CurrentThread.CurrentUICulture =
                Thread.CurrentThread.CurrentCulture =
                CultureInfo.CreateSpecificCulture(cultureName);
        }
    }
}
