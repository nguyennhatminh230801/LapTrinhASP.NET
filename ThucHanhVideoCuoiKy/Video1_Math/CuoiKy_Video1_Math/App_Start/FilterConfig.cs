using System.Web;
using System.Web.Mvc;

namespace CuoiKy_Video1_Math
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
