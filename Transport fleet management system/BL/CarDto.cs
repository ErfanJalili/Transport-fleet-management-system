using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_fleet_management_system.BL
{
    public class CarDto
    {
        public int Id { get; set; }
        public string VehicleName { get; set; }
        public string VehicleTypeName { get; set; }
        public string FuelTypeName { get; set; }
        public string BarrackCategory { get; set; }
        public string VehicleBrandName { get; set; }
        public string EngineNumber { get; set; }
        public string ChassisNumber { get; set; }
        public string PlateNumber { get; set; }
        public string PlateSeriesNumber { get; set; }
        public string CarCode { get; set; }
        public string Created_Year { get; set; }
        public string Color { get; set; }
        public DateTime? Created_At { get; set; }
        public DateTime? Updated_At { get; set; }
        public string VehicleStatus { get; set; }
        public byte[] Image { get; set; }
        public int CurrentMileage { get; set; }
    }
}
