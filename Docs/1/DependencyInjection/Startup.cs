using DependencyInjection.Services;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddScoped<ICounter, Counter>();
            //services.AddSingleton<ICounter, Counter>();
            services.AddTransient<ICounter, Counter>();

            services.AddTransient<IMyOtherService, MyOtherService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
