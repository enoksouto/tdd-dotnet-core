using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using Autofac.Extras.Moq;
using FluentAssertions;
using Moq;
using Tdd.CreditCards.Api.Models;
using Tdd.CreditCards.Api.Controllers;
using Tdd.CreditCards.Entities;
using Tdd.CreditCards.Business.Interfaces;

namespace Tdd.CreditCards.Tests.Api
{
    public class CreditCardApplicationControllerTest
    {
        [Fact]
        public void AddCreditCardApplicationShouldReturnOk()
        {
            // Arrange
            var model = new CreditCardApplicationModel()
            {
                FirstName = "Enok",
                LastName = "Souto",
                Age = 31,
                GrossAnnualIncome = 200000
            };

            var repositoryMock = new Mock<ICreditCardApplicationService>();
            repositoryMock.Setup(r => r.AddAsync(It.IsAny<CreditCardApplication>()));
                
            var controller = new CreditCardApplicationController(repositoryMock.Object);

            // Act
            var result = controller.Add(model);

            // Assert
            result.Should().BeOfType<OkObjectResult>();
        }
    }
}
