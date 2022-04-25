using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Core_WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// IHostBuilder: A COnreact between the Application and the Host (IIS, Docker, Self-Host, etc.). THis will make the AS.NET COre as a REal-Cross-PLatform Technology
        /// 
        /// Host: COnfigure the Host with Default Settings (Sesesion TimeOut, No. of Requests, caching (In-Memory), etc.). On the top of that, if Startup class has any other additional settings (or services) then use them and configre on Host 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    //webBuilder.UseKestrel();
                    //webBuilder.UseContentRoot(Directory.GetCurrentDirectory());
                    //webBuilder.UseIISIntegration();
                    // use the Startup class
                    // Instantiate the Startup class and pass ICOnfigration to it
                    webBuilder.UseStartup<Startup>();
                    
                });
    }
}
