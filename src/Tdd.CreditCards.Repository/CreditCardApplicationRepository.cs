using System.Threading.Tasks;
using Tdd.CreditCards.Entities;
using Tdd.CreditCards.Infra.Data;
using Tdd.CreditCards.Repository.Interfaces;

namespace Tdd.CreditCards.Repository
{
    public class CreditCardApplicationRepository : ICreditCardApplicationRepository
    {
        private readonly CreditCardsDbContext _dbContext;

        public CreditCardApplicationRepository(CreditCardsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task AddAsync(CreditCardApplication application)
        {
            _dbContext.CreditCardApplications.Add(application);

            return _dbContext.SaveChangesAsync();
        }
    }
}