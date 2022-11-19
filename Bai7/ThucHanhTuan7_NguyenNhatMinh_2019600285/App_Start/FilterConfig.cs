using System.Web;
using System.Web.Mvc;

namespace ThucHanhTuan7_NguyenNhatMinh_2019600285
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
