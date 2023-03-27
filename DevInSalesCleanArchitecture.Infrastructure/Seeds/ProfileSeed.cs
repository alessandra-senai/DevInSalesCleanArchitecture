using DevInSalesCleanArchitecture.Domain.Entities;

namespace DevInSalesCleanArchitecture.Infrastructure.Seeds
{
    public class ProfileSeed
    {
        public static List<Profile> Seed { get; set; } = new List<Profile>() { new Profile(1, "Cliente") };
    }
}
