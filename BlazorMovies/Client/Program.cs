using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;
using BlazorMovies.Client.Helpers;

namespace BlazorMovies.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            ConfigurServices(builder.Services);

            await builder.Build().RunAsync();
        }

        private static void ConfigurServices(IServiceCollection services)
        {
            services.AddOptions();      //Authorization System
            services.AddSingleton<SingletonService>();
            services.AddTransient<TransientService>();
            //get Movies services
            services.AddTransient<IRepository, Repository>();
        }

    }
}
