using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMvcApp
{
    public static class Helper
    {
        public static string MySubstring(this string str, int startIndex, int endIndex)
        {
            return str.Substring(startIndex);
        }

        public static MvcHtmlString NumberEditor(this HtmlHelper helper, string name)
        {
            return MvcHtmlString.Create(string.Format("<input type='number' name='{0}' />", name));
        }

        public static MvcHtmlString FarsiDp(this HtmlHelper helper, string name)
        {
            return MvcHtmlString.Create(string.Format("<input type='text' class='datepicker' name='{0}' />", name));
        }
    }


    public static class Test
    {
        public static void F()
        {
            string str = "Message";

            str = str.MySubstring(1, 5);

            var str1 = Helper.MySubstring("", 1, 2);


        }
    }
}