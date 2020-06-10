using Tdd.CreditCards.Repository;
using Tdd.CreditCards.Repository.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Tdd.CreditCards.Api.DependencyInjection
{
    public static class RepositoryDependenciesResolver
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICreditCardApplicationRepository, CreditCardApplicationRepository>();
            
            return services;
        }
    }
}