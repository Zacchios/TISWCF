using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;
using WCFHOST;

namespace WCFHOST
{
    class Program
    {
        private static readonly object WebApp;

        static void Main(string[] args)
        {
            using (WebApp.Start<startup>("http://localhost:50275"))
            {
                Console.WriteLine("Web Server is running.");
                Console.WriteLine("Press any key to quit.");
                Console.ReadLine();
            }
        }
    }
}
