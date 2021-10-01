using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_fleet_management_system.BL
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int VehicletypeId { get; set; }
        public int FuelTypeId { get; set; }
        public int BarrackCategoryId { get; set; }
        public int VehicleBrandId { get; set; }
        public string EngineNumber { get; set; }
        public string ChassisNumber { get; set; }
        public string PlateNumber { get; set; }
        public string PlateSeriesNumber { get; set; }
        public string CarCode { get; set; }
        public string Created_Year { get; set; }
        public string Color { get; set; }
        public DateTime? Created_At { get; set; }
        public DateTime? Updated_At { get; set; }
        public int VehicleStatusId { get; set; }
        public byte[] Image { get; set; }
        public int CurrentMileage { get; set; }

    }

}
