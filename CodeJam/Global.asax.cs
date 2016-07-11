using System.Web.Routing;
using CodeJam.Data.Migrations;

namespace CodeJam
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Runner.SqlServer("CodeJam").Up();
        }
    }
}