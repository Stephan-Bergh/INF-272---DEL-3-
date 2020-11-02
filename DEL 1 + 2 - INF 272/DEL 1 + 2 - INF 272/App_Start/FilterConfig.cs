using System.Web;
using System.Web.Mvc;

namespace DEL_1___2___INF_272
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
