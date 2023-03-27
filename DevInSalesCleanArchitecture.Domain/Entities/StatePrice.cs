using System.ComponentModel.DataAnnotations;

namespace DevInSalesCleanArchitecture.Domain.Entities
{
    public class StatePrice
    {
        [Key]
        public int Id { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
        public int ShippingCompanyId { get; set; }
        public ShippingCompany ShippingCompany { get; set; }
        public decimal BasePrice { get; set; }

    }
}
