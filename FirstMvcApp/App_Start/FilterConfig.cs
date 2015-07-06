using FirstMvcApp.Controllers;
using System.Web;
using System.Web.Mvc;

namespace FirstMvcApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new MyCustomFilter());
        }
    }
}
