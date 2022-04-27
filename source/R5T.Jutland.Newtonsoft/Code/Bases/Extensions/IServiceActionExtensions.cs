using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0062;
using R5T.T0063;


namespace R5T.Jutland.Newtonsoft
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="NewtonsoftJsonFileSerializationOperator"/> implementation of <see cref="IJsonFileSerializationOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IJsonFileSerializationOperator> AddNewtonsoftJsonFileSerializationOperatorAction(this IServiceAction _)
        {
            var serviceAction = _.New<IJsonFileSerializationOperator>(services => services.AddNewtonsoftJsonFileSerializationOperator());
            return serviceAction;
        }
    }
}
