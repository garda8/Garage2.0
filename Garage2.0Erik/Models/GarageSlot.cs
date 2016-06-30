using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Garage2._0Erik.Models
{
    public class GarageSlot
    {   
        [Key]
        public int ID { get; set; }
        public Vehicle PVehicle { get; set; }
        public DateTime PTime { get; set; } 
    }
}