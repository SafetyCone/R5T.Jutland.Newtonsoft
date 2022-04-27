using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0063;


namespace R5T.Jutland.Newtonsoft
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="NewtonsoftJsonFileSerializationOperator"/> implementation of <see cref="IJsonFileSerializationOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddNewtonsoftJsonFileSerializationOperator(this IServiceCollection services)
        {
            services.AddSingleton<IJsonFileSerializationOperator, NewtonsoftJsonFileSerializationOperator>();

            return services;
        }
    }
}
