using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tdd.CreditCards.Api.Models;
using Tdd.CreditCards.Business.Interfaces;
using Tdd.CreditCards.Entities;
using Tdd.CreditCards.Repository.Interfaces;

namespace Tdd.CreditCards.Api.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CreditCardApplicationController : ControllerBase
    {
        private readonly ICreditCardApplicationService _applicationService;

        public CreditCardApplicationController(ICreditCardApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        /// <summary>
        /// Add new credit card application
        /// </summary>
        /// <param name="creditCardInfo">credit card application info</param>
        /// <response code="200">Application created with success.</response>
        /// <response code="400">request with invalid info.</response>
        [HttpPost]
        public IActionResult Add([FromBody] CreditCardApplicationModel creditCardInfo)
        {
            try
            {
                var creditCardApplication = new CreditCardApplication
                {
                    FirstName = creditCardInfo.FirstName,
                    LastName = creditCardInfo.LastName,
                    Age = creditCardInfo.Age.Value,
                    GrossAnnualIncome = creditCardInfo.GrossAnnualIncome.Value
                };                

                _applicationService.AddAsync(creditCardApplication).Wait();

                return Ok("Creditcard application created with success.");    
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }            
        }
    }
}
