using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Fluxor;
using FluxorDemo01.Shared;

namespace FluxorDemo01
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped<HttpProcessingDelegatingHandler>();

            builder.Services
                .AddHttpClient("local", c => c.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
                .AddHttpMessageHandler<HttpProcessingDelegatingHandler>();

            builder.Services.AddFluxor(options => options
                .ScanAssemblies(typeof(Program).Assembly)
                .UseRouting()
                .UseReduxDevTools()
            );

            await builder.Build().RunAsync();
        }
    }
}
