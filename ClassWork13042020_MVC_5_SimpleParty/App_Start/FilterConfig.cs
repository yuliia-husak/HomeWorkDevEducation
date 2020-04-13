using System.Web;
using System.Web.Mvc;

namespace ClassWork13042020_MVC_5_SimpleParty
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
