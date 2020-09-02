using System;
using Microsoft.Extensions.DependencyInjection;

namespace AutoMapperBuilder.Extensions.DependencyInjection
{
    public static class AutoMapperBuilderExtensions
    {
        /// <summary>
        /// Adds AutoMapperBuilder to the specified <see cref="IServiceCollection"/>.
        /// </summary>
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
