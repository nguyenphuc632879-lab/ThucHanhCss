using System.Web;
using System.Web.Mvc;

namespace Thực_Hành_Css
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
