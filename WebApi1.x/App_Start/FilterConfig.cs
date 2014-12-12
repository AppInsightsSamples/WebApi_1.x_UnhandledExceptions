using System.Web;
using System.Web.Mvc;
using WebApi1.x.App_Start;

namespace WebApi1.x
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new AiHandleErrorAttribute());
            //filters.Add(new HandleErrorAttribute());
        }
    }
}