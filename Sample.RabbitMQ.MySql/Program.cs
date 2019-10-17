using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Sample.RabbitMQ.MySql
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string port = "5000";
            if (Environment.GetEnvironmentVariable("PORT") != null) {
                port = Environment.GetEnvironmentVariable("PORT");
            }
            Console.WriteLine("Listing :{0}", port);
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseUrls ($"http://0.0.0.0:{port}")
                .UseStartup<Startup>();
    }
}
