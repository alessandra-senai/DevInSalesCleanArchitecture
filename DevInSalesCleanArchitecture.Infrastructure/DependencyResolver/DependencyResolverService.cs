using DevInSalesCleanArchitecture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevInSalesCleanArchitecture.Infrastructure.DependencyResolver
{
    public static class DependencyResolverService
    {
        public static void Register(IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<DevInSalesDbContext>(options =>
                options.UseSqlServer("name=ConnectionStrings:ServerConnection",
                x => x.MigrationsAssembly("DevInSalesCleanArchitecture.Infrastructure")));

           
        }

        public static void MigrateDatabase(IServiceProvider serviceProvider)
        {
            var dbContextOptions = serviceProvider.GetRequiredService<DbContextOptions<DevInSalesDbContext>>();
            using (var dbContext = new DevInSalesDbContext(dbContextOptions))
            {
                dbContext.Database.Migrate();
            }
        }
    }
}