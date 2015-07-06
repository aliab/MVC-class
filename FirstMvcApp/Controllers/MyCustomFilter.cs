using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMvcApp.Controllers
{
    public class MyCustomFilter : FilterAttribute,IActionFilter
    {
        private static int Counter = 0;
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Counter++;
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
        }
    }

    //public class MyCustomResultFilter : FilterAttribute, IResultFilter
    //{
    //    private static int Counter = 0;
    //    public void OnActionExecuted(ActionExecutedContext filterContext)
    //    {
    //        Counter++;
    //    }

    //    public void OnActionExecuting(ActionExecutingContext filterContext)
    //    {
    //    }
    //}
}