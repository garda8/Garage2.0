using Garage2._0Erik.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Garage2._0Erik.DataAccessLayer
{
    public class GarageContext : DbContext
    {
        public GarageContext() : base("DefaultConnection") { }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<GarageSlot> Slots { get; set; }

    }
}