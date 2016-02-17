using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _15扩展Demo.Models
{
    public static class MyExtensions
    {
        public static string MyExtensionMethod(this HtmlHelper html)
        {
            return "Hello World!";
        }
    }
}