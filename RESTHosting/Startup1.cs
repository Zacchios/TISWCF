using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.UI.WebControls;
using System.Web.Http;

[assembly: OwinStartup(typeof(RESTHosting.Startup1))]

namespace RESTHosting
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            
                //Configuration web API for self-host
                var config = new HttpConfiguration();              

            config.Routes.MapHttpRoute(
                    name: "DefaultApi",
                    routeTemplate: "api/{controller}/{id}",
                    defaults: new { id = RouteParameter.Optional }
                );
                app.UseWebApi(config);
            }
        
    }
}
