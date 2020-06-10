using System.Threading.Tasks;
using Tdd.CreditCards.Entities;

namespace Tdd.CreditCards.Repository.Interfaces
{
    public interface ICreditCardApplicationRepository
    {
        Task AddAsync(CreditCardApplication application);
    }
}
