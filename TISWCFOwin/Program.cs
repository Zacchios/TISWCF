using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace TISWCFOwin
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>
           {
               x.Service<WebServer>(s =>
               {
                   s.ConstructUsing(name => new WebServer());
                   s.WhenStarted(tc => tc.Start());
                   s.WhenStopped(tc => tc.Stop());
               });
               x.RunAsLocalSystem();
               x.SetDescription("Service for The Inventory System");
               x.SetDisplayName("TISService");
               x.SetServiceName("TISService");
           });
        }
    }
}
