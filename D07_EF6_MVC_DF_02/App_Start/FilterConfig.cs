using System.Web;
using System.Web.Mvc;

namespace D07_EF6_MVC_DF_02
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
