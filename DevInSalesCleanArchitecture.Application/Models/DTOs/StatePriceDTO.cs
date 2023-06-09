﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevInSalesCleanArchitecture.Application.Models.DTOs
{
    public class StatePriceDTO
    {
        [Required(ErrorMessage = "O estado deve ser informado.")]
        public int StateId { get; set; }

        [Required(ErrorMessage = "A compania deve ser Informada")]
        public int ShippingCompanyId { get; set; }

        [Required(ErrorMessage = "O valor da tabela deve ser informado.")]
        [Range(1, 200000, ErrorMessage = "O valor da tabela deve ser entre R$ 1,00 a R$ 200.000,00 e ")]
        public decimal BasePrice { get; set; }
    }
}
