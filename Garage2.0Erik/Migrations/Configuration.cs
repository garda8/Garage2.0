namespace Garage2._0Erik.Migrations
{
    using Garage2._0Erik.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Garage2._0Erik.DataAccessLayer.GarageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Garage2._0Erik.DataAccessLayer.GarageContext context)
        {
            context.Vehicles.AddOrUpdate(
                new Vehicle() { RegNr = "ABC111", Color = ColorType.Green, Type = VehicleType.Car, NumberOfWheels = 4, Owner = "Michael Moore" }
            );
        }
    }
}
