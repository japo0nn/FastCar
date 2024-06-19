using FastCarServer.Application.Common.Interfaces.Data;
using FastCarServer.Core.Data;
using FastCarServer.Core.Data.CarAbstract;
using FastCarServer.Core.Data.Passenger;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FastCarServer.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<PassengerCategory> PassengerCategories => Set<PassengerCategory>();
        public DbSet<PassengerBrand> PassengerBrands => Set<PassengerBrand>();
        public DbSet<PassengerBrandModel> PassengerBrandModels => Set<PassengerBrandModel>();
        public DbSet<PassengerBodyType> PassengerBodyTypes => Set<PassengerBodyType>();
        public DbSet<PassengerBrandYear> PassengerBrandYears => Set<PassengerBrandYear>();
        public DbSet<PassengerGeneration> PassengerGenerations => Set<PassengerGeneration>();
        public DbSet<PassengerCar> PassengerCars => Set<PassengerCar>();
        public DbSet<FieldOption> FieldOptions => Set<FieldOption>();
        public DbSet<Field> Fields => Set<Field>();
        public DbSet<Property> Properties => Set<Property>();

        public DbSet<Car> Cars => Set<Car>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
