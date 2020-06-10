using Microsoft.EntityFrameworkCore;
using Tdd.CreditCards.Entities;

namespace Tdd.CreditCards.Infra.Data
{
    public class CreditCardsDbContext : DbContext
    {
        public CreditCardsDbContext(DbContextOptions<CreditCardsDbContext> dbContextOptions) :
            base(dbContextOptions)
        {
        }

        public DbSet<CreditCardApplication> CreditCardApplications { get; set; }
    }
}