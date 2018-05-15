using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Owin;
using System.Web.Http;
using RESTHosting;
using System.Configuration;

namespace TISWCFOwin
{
   public  class startup
    {
        public void Configuration(IAppBuilder app)
        {

           // string sconfig = ConfigurationManager.AppSetting("C:\Users\Pierre\Documents\TFE\WCF\TISWCF\TISWCF\Web.config");

            var config = new HttpConfiguration();
            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }
    }
}
