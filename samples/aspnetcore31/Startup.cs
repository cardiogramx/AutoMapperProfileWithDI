using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using AutoMapperBuilder.Extensions.DependencyInjection;

namespace AutoMapperProfileWithDI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //Registering MyService in the DI container
            services.AddTransient<IMyService, MyService>();

            var provider = services.BuildServiceProvider();

            services.AddAutoMapperBuilder(builder =>
            {
                builder.Profiles.Add(new MyClass(provider.GetRequiredService<IMyService>()));
            });

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
