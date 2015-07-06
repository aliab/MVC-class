using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FirstMvcApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //AboutUs
            routes.MapRoute(
              name: "About",
              url: "About/{dep}",
              defaults: new { controller = "Home", action = "About",dep=UrlParameter.Optional }
          );
            routes.MapRoute(
              name: "ViewStudent",
              url: "Student/View/{id}",
              defaults: new { controller = "Students", action = "ViewStudent" },
              constraints: new { id=@"\d+" }
          );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }

    public class StudentIdConstraint : IRouteConstraint
    {

        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            var sid = values["id"];
            //Check sid exist in Student Table!

            return true; // 
        }
    }
}
