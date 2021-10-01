using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_fleet_management_system.BL
{
    public class Fuel
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public DateTime? Created_At { get; set; }
        public DateTime? Update_At { get; set; }
        public int LastMileage { get; set; }
        public int CurrentMileage { get; set; }
        public int CarFunction { get; set; }
        public int ConsumptionLiters { get; set; }
        public string PriceOfEachLiter { get; set; }
        public string Price { get; set; }
       
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        
        public int FuelTypeId { get; set; }
        public string Comment { get; set; }
        public float Liter { get; set; }
        public int FactorNumber { get; set; }
        public string RegistereName { get; set; }
    }
}
