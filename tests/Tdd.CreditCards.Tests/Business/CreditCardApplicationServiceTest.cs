using System;
using System.Threading.Tasks;
using Xunit;
using Autofac.Extras.Moq;
using FluentAssertions;
using Moq;
using Tdd.CreditCards.Entities;
using Tdd.CreditCards.Business;
using Tdd.CreditCards.Repository.Interfaces;

namespace Tdd.CreditCards.Tests.Business
{
    public class CreditCardApplicationServiceTest
    {
        [Fact]
        public void AddCreditCardApplicationShouldReturnOk()
        {
            // Arrange
            var application = new CreditCardApplication()
            {
                FirstName = "Enok",
                LastName = "Souto",
                Age = 31,
                GrossAnnualIncome = 200000
            };

            var repositoryMock = new Mock<ICreditCardApplicationRepository>();
            repositoryMock.Setup(r => r.AddAsync(It.IsAny<CreditCardApplication>()));
                
            var service = new CreditCardApplicationService(repositoryMock.Object);

            // Act
            service.AddAsync(application).Wait();

            // Assert
            repositoryMock.Verify(x => x.AddAsync(application), Times.Once());
        }
    }
}
