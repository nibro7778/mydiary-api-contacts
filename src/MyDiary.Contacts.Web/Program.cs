

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
builder.Logging.AddJsonConsole();

app.MapGet("/", () => "Hello World!");

app.UseStaticFiles();

app.Run();



//using Autofac.Extensions.DependencyInjection;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.Extensions.Hosting;
//using Microsoft.Extensions.Logging;

//namespace MyDiary.Contacts.Web
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            CreateHostBuilder(args).Build().Run();
//        }

//        public static IHostBuilder CreateHostBuilder(string[] args) =>
//            Host.CreateDefaultBuilder(args)
//                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
//                .ConfigureLogging(logging =>
//                {
//                    logging.ClearProviders();
//                    logging.AddConsole();
//                })
//                .ConfigureWebHostDefaults(webBuilder =>
//                {
//                    webBuilder.UseStartup<Startup>();
//                });
//    }
//}
