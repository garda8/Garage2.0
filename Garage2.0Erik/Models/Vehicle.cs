using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Garage2._0Erik.Models
{
    public class Vehicle
    {
        [Key]
        public string RegNr { get; set; }
        
        public string Owner  { get; set; }
        
        public ColorType Color { get; set; }
        
        public int NumberOfWheels { get; set; }

        public VehicleType Type { get; set; }
    }

    public enum VehicleType
    {
        Car,
        Truck, 
        Bus,
        Boat,
        Motorcycle
    }

    public enum ColorType
    {
        White,
        Grey,
        Yellow,
        Red,
        Blue,
        Green,
        Black

    }
}