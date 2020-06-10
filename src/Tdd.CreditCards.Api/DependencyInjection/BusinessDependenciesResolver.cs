using Microsoft.Extensions.DependencyInjection;
using Tdd.CreditCards.Business;
using Tdd.CreditCards.Business.Interfaces;

namespace Tdd.CreditCards.Api.DependencyInjection
{
    public static class BusinessDependenciesResolver
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<ICreditCardApplicationService, CreditCardApplicationService>();

            return services;
        }
    }
}