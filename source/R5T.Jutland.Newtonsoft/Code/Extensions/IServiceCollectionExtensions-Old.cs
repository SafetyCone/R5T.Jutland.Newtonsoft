using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Jutland.Newtonsoft
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="NewtonsoftJsonFileSerializationOperator"/> implementation of <see cref="IJsonFileSerializationOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddNewtonsoftJsonFileSerializationOperator_Old(this IServiceCollection services)
        {
            services.AddSingleton<IJsonFileSerializationOperator, NewtonsoftJsonFileSerializationOperator>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="NewtonsoftJsonFileSerializationOperator"/> implementation of <see cref="IJsonFileSerializationOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IJsonFileSerializationOperator> AddNewtonsoftJsonFileSerializationOperatorAction_Old(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IJsonFileSerializationOperator>(() => services.AddNewtonsoftJsonFileSerializationOperator_Old());
            return serviceAction;
        }
    }
}
