using AutoMapper;
using DevInSalesCleanArchitecture.Domain.Entities;

namespace DevInSalesCleanArchitecture.Application.Models.DTOs.Request
{
    public class ProductPutRequestDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public decimal Suggested_Price { get; set; }

        public static Product ConverterParaEntidade(ProductPostRequestTO requisicao, int id = 0)
        {
            if (requisicao == null)
                return null;


            var configuration = new MapperConfiguration(cfg =>
                    cfg.CreateMap<Product, ProductPostRequestTO>());
            var mapper = configuration.CreateMapper();

            return mapper.Map<Product>(requisicao);
        }
    }
}
