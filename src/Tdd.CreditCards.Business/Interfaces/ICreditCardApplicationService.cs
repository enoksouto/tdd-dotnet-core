using System.Threading.Tasks;
using Tdd.CreditCards.Entities;

namespace Tdd.CreditCards.Business.Interfaces
{    public interface ICreditCardApplicationService
    {         Task AddAsync(CreditCardApplication application);
    }
}