using System;
using System.Threading.Tasks;
using Tdd.CreditCards.Entities;
using Tdd.CreditCards.Repository.Interfaces;

namespace Tdd.CreditCards.Business
{
    public class CreditCardApplicationService : Interfaces.ICreditCardApplicationService
    {
        private readonly ICreditCardApplicationRepository _applicationRepository;

        public CreditCardApplicationService(ICreditCardApplicationRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }

        public Task AddAsync(CreditCardApplication application)
        {
            return _applicationRepository.AddAsync(application);
        }
    }
}
