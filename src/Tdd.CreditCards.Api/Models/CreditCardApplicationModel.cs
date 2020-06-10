using System.ComponentModel.DataAnnotations;

namespace Tdd.CreditCards.Api.Models
{
    public class CreditCardApplicationModel
    {
        public string FirstName { get; set; }

        public string LastName{ get; set; }

        public int? Age { get; set; }
    
        public decimal? GrossAnnualIncome { get; set; }
    }
}
