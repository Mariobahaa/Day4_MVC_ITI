using System.Web;
using System.Web.Mvc;

namespace Day4_MVC_ITI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute()
            {
                View = "Error"
            });
        }
    }
}
