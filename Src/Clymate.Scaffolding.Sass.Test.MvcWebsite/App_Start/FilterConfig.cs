using System.Web;
using System.Web.Mvc;

namespace Clymate.Scaffolding.Sass.Test.MvcWebsite
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
