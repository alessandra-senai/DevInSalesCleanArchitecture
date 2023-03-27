using System.ComponentModel.DataAnnotations;

namespace DevInSalesCleanArchitecture.Domain.Entities
{
    public class ShippingCompany
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
