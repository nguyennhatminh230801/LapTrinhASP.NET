using System.Web;
using System.Web.Mvc;

namespace CuoiKy_Video4_LoginLogout_Database
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
