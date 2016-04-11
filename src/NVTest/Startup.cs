using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.ApplicationInsights.AspNet;
using NVTest.Models;
using Newtonsoft.Json.Serialization;

namespace NVTest
{
    public class Startup
    {
        public static IConfigurationRoot Configuration { get; set;}

        public Startup(IApplicationEnvironment appEnv, IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(appEnv.ApplicationBasePath)
                .AddJsonFile("config.json")
                .AddEnvironmentVariables();
            Configuration = builder.Build();

            if(env.IsDevelopment())
            {
                builder.AddApplicationInsightsSettings(developerMode: true);
            }
            
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                .AddJsonOptions(opt =>
                {
                    opt.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                });
            services.AddEntityFramework()
                .AddSqlServer()
                .AddDbContext<ResultsContext>()
                .AddDbContext<TestContext>();

            services.AddSingleton<TestContextSeedData>();
            services.AddScoped<ITestRepository, TestRepository>();
            services.AddScoped<IResultsRepository, ResultsRepository>();

            services.AddApplicationInsightsTelemetry(Configuration);
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IServiceProvider serviceProvider)
        {
            app.UseApplicationInsightsRequestTelemetry();
            app.UseApplicationInsightsExceptionTelemetry();
            app.UseStaticFiles();

            app.UseMvc(config =>
            {
                config.MapRoute(
                  name: "Default",
                  template: "{controller}/{action}/{id?}",
                  defaults: new { controller = "Home", action = "Index" }
                  );
            });
            var seeder = serviceProvider.GetService<TestContextSeedData>();
            seeder.EnsureSeedData();
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
