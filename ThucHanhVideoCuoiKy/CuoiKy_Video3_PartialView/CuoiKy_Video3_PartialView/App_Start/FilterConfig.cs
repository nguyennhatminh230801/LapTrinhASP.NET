using System.Web;
using System.Web.Mvc;

namespace CuoiKy_Video3_PartialView
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
