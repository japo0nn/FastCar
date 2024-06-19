using FastCarServer.Core.Data;
using FastCarServer.Core.Data.CarAbstract;
using FastCarServer.Core.Data.Passenger;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCarCore.Application.Common.Interfaces.Configurations
{
    public interface IApplicationDbContext
    {
        DbSet<PassengerCategory> PassengerCategories { get; }
        DbSet<PassengerBrand> PassengerBrands { get; }
        DbSet<PassengerBrandModel> PassengerBrandModels { get; }
        DbSet<PassengerBodyType> PassengerBodyTypes { get; }
        DbSet<PassengerBrandYear> PassengerBrandYears { get; }
        DbSet<PassengerGeneration> PassengerGenerations { get; }
        DbSet<PassengerCar> PassengerCars { get; }
        DbSet<FieldOption> FieldOptions { get; }
        DbSet<Field> Fields { get; }
        DbSet<Property> Properties { get; }

        DbSet<Car> Cars { get; }

    }
}
