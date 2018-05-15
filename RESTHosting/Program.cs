using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTHosting
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebApp.Start<Startup1>("http://localhost:50275"))
                ^{

            }
        }
    }

   
}
