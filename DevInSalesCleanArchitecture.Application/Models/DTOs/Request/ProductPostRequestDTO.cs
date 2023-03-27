using AutoMapper;
using DevInSalesCleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevInSalesCleanArchitecture.Application.Models.DTOs.Request
{
    public class ProductPostRequestTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public decimal Suggested_Price { get; set; }

        public  static Product ConverterParaEntidade(ProductPostRequestTO requisicao, int id = 0)
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
