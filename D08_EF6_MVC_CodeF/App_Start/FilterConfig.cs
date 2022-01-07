using System.Web;
using System.Web.Mvc;

namespace D08_EF6_MVC_CodeF
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
