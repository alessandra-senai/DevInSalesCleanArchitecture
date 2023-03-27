namespace DevInSalesCleanArchitecture.Application.Models.DTOs.Request
{
    internal class OrderRequestDTO
    {
        public int UserId { get; set; }
        public int SellerId { get; set; }
        public DateTime Date_Order { get; set; }

    }
}
