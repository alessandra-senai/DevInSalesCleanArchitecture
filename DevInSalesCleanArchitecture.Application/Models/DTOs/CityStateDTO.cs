using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevInSalesCleanArchitecture.Application.Models.DTOs
{
    internal class CityStateDTO
    {
        public int City_Id { get; set; }
        public string Name_City { get; set; }
        public int State_Id { get; set; }
        public string Name_State { get; set; }
        public string Initials { get; set; }
    }
}
