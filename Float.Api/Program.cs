using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;
using System.IO;

namespace Float.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Read Configuration from appSettings
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            string applicationPath=  Directory.GetCurrentDirectory();
            Environment.SetEnvironmentVariable("Float.Api Logs", applicationPath);
            //Initialize Logger
            Log.Logger = new LoggerConfiguration().
                ReadFrom.Configuration(config).
                CreateLogger();

            try
            {
                Log.Information("Float.Api Starting.");
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception error)
            {
                Log.Fatal(error, "Float.Api Failed to start");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .UseSerilog() //using serilog instead of .net logger
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
