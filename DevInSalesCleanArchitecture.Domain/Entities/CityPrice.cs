using System.ComponentModel.DataAnnotations;

namespace DevInSalesCleanArchitecture.Domain.Entities
{
    public class CityPrice
    {
        [Key]
        public int Id { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public ShippingCompany ShippingCompany { get; set; }
        public decimal BasePrice { get; set; }
        public int ShippingCompanyId { get; set; }
    }
}
