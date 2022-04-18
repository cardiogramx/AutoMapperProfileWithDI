using System;
using Microsoft.Extensions.DependencyInjection;

namespace AutoMapperBuilder.Extensions.DependencyInjection
{
    public static class AutoMapperBuilderExtensions
    {
        /// <summary>
        /// Adds AutoMapperBuilder to the specified <see cref="IServiceCollection"/>.
        /// </summary>
        public static IServiceCollection AddAutoMapperBuilder(this IServiceCollection services, Action<AutoMapperBuilderConfiguration> builder)
        {
            //Configures IOptions<AutoMapperBuilderConfiguration>
            services.Configure(builder);
            
            //Registers IAutoMapperBuilder in the service container
            services.AddSingleton<IAutoMapperBuilder, AutoMapperBuilder>();

            //Builds IMapper and add to the service container
            services.AddSingleton(provider => provider.GetRequiredService<IAutoMapperBuilder>().Build());

            return services;
        }
    }
}
