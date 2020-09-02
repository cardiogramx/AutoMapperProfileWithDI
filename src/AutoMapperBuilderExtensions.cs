using System;
using Microsoft.Extensions.DependencyInjection;

namespace AutoMapperBuilder.Extensions.DependencyInjection
{
    public static class AutoMapperBuilderExtensions
    {
        public static IServiceCollection AddAutoMapperBuilder(this IServiceCollection services, Action<AutoMapperBuilderConfiguration> option)
        {
            //Configure IOptions<AutoMapperBuilderConfiguration>
            services.Configure(option);

            //Registering IAutoMapperBuilder in the DI container
            services.AddTransient<IAutoMapperBuilder, AutoMapperBuilder>();

            return services;
        }
    }
}
