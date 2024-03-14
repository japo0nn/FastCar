using FastCarServer.Data;
using FastCarServer.Data.CarAbstract;
using FastCarServer.Data.Passenger;
using FastCarServer.Data.User;
using Microsoft.EntityFrameworkCore;

namespace FastCarServer.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<PassengerCategory> PassengerCategories { get; set; }
        public DbSet<PassengerBrand> PassengerBrands { get; set; }
        public DbSet<PassengerBrandModel> PassengerBrandModels { get; set; }
        public DbSet<PassengerBodyType> PassengerBodyTypes { get; set; }
        public DbSet<PassengerBrandYear> PassengerBrandYears { get; set; }
        public DbSet<PassengerGeneration> PassengerGenerations { get; set; }
        public DbSet<PassengerCar> PassengerCars { get; set; }
        public DbSet<FieldOption> FieldOptions { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<Properties> Properties { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
