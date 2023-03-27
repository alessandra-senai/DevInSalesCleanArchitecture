using DevInSalesCleanArchitecture.Application.Models.DTOs;

namespace DevInSalesCleanArchitecture.Application.Models.Dtos
{
    internal class AddressDTO
    {
        public string CEP { get; set; }
        public string Street { get; set; }
        public CityStateDTO CityStateDTO { get; set; }
    }
}
