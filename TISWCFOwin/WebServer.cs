using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TISWCFOwin
{
   public class WebServer
    {
        private IDisposable _webapp;

        public void Start()
        {
            //_webapp = WebApp.Start<startup>("http://192.168.1.5:50276");
           // _webapp = WebApp.Start<startup>("http://localhost:50276");
            _webapp = WebApp.Start<startup>("http://192.168.43.111:50276");
        }

        public void Stop()
        {
            _webapp?.Dispose();
        }
    }
}
