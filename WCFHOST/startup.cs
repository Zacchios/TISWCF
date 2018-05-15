
using System.Web.Http;
using Owin;
using System.Web.UI.WebControls;

namespace WCFHOST
{
    class startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
               name: "DefaultApi",
               routeTemplate: "api/{controller}/{id}",
               defaults: new { id = RouteParameter.Optional }
        }
    }
}
