using DevInSalesCleanArchitecture.Domain.Entities;

namespace DevInSalesCleanArchitecture.Infrastructure.Seeds
{
    public class CategorySeed
    {
        public static List<Category> Seed { get; set; } = new List<Category>() { new Category(1, "Categoria Padrão", "categoria-padrao") };
    }
}
