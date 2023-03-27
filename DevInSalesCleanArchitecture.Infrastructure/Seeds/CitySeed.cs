using DevInSalesCleanArchitecture.Domain.Entities;

namespace DevInSalesCleanArchitecture.Infrastructure.Seeds
{
    public static class CitySeed
    {

        public static List<City> Seed { get; set; } = new List<City>()
        {
            new City
            {
                Id = 1,
                State_Id = 52,
                Name = "Goiânia"
            },
            new City
            {
                Id = 2,
                State_Id = 42,
                Name = "Florianópollis"
            },
        };
    }
}