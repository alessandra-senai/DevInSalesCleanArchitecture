using DevInSalesCleanArchitecture.Domain.Enums;

namespace DevInSalesCleanArchitecture.Domain.Entities
{
    public class Delivery
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public Address Address { get; set; }
        public DateTime Delivery_Forecast { get; set; }
        public DateTime? Delivery_Date { get; set; }
        public StatusEnum Status { get; set; }

    }
}
