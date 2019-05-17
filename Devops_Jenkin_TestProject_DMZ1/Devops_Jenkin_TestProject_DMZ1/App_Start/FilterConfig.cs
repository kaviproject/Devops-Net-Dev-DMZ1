using System.Web;
using System.Web.Mvc;

namespace Devops_Jenkin_TestProject_DMZ1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
