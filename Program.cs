using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DegitalFingerP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webBuilder =>
        {
            //webBuilder.ConfigureKestrel(serverOptions =>
            //{
            //    serverOptions.Listen(IPAddress.Loopback, 5025);
            //})
            webBuilder.UseStartup<Startup>()
            .UseSetting("https_port", "443");
        });
        ///////////////////////////////////////////////////////////////////////////
        //.ConfigureWebHostDefaults(webBuilder =>
        //{
        //    webBuilder.UseStartup<Startup>();
        //});
    }
}
