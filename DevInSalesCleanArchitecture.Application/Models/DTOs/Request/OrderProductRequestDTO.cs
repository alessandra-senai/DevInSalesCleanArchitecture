using AutoMapper;
using DevInSalesCleanArchitecture.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace DevInSalesCleanArchitecture.Application.Models.DTOs.Request
{
    public class OrderProductRequestDTO
    {
        [Required(ErrorMessage = "O campo Unit_Price do OrderProduct precisa ser informado.")]
        public decimal Unit_Price { get; set; }

        [Required(ErrorMessage = "O campo Amount do OrderProduct precisa ser informado.")]
        public int Amount { get; set; }

        [Required(ErrorMessage = "O campo Product_Id do OrderProduct precisa ser informado.")]
        public int Product_Id { get; set; }

        [Required(ErrorMessage = "O campo Order_Id do OrderProduct precisa ser informado.")]
        public int Order_Id { get; set; }

        public static OrderProduct ConverterParaEntidade(OrderProductRequestDTO orderProduct, OrderProduct product, Order order)
        {
            if (orderProduct == null) return null;
 
            var configuration = new MapperConfiguration(cfg =>
                   cfg.CreateMap<OrderProduct, OrderProductRequestDTO>());
            var mapper = configuration.CreateMapper();

            return mapper.Map<OrderProduct>(orderProduct);
        }

    }
}
