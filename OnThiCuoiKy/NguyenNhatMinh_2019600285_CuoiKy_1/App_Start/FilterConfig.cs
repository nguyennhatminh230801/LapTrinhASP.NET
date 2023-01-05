using System.Web;
using System.Web.Mvc;

namespace NguyenNhatMinh_2019600285_CuoiKy_1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
