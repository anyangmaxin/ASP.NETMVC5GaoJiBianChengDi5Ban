using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;

namespace _16Demo.Models
{
    public abstract class CustomWebViewPage<T> : WebViewPage<T>
    {
        public HelperResult RenderSection(string name, Func<dynamic, HelperResult> defaultContents)
        {
            if (IsSectionDefined(name))
            {
                return RenderSection(name);
            }
            return defaultContents(null);
        }
    }
}