using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace StatsWebService.Filters
{
    public class ModelValidatorAttribute : ActionFilterAttribute
    {
        // This method is called by the ASP.NET MVC framework before the action method is executes
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest,
                actionContext.ModelState);
        }

    }
}