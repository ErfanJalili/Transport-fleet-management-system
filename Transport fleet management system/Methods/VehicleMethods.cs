using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport_fleet_management_system.BL;

namespace Transport_fleet_management_system.Methods
{
    public class VehicleMethods
    {
        private readonly IDbConnection _dbConnection;
        public VehicleMethods(IDbConnection db)
        {
            _dbConnection = db;
        }
        public List<CarBrand> GetCarBrands() 
        {
            string query = $" SELECT * FROM  tblVehicleBrand";

            var result= _dbConnection.Query<CarBrand>(query, commandType: CommandType.Text).ToList();
            return result;
        }

        public List<CarFuelType> GetCarFuleTypes()
        {
            string query = $" SELECT * FROM  tblFuelType";

            var result = _dbConnection.Query<CarFuelType>(query, commandType: CommandType.Text).ToList();
            return result;
        }

        public List<CarType> GetCarTypes()
        {
            string query = $" SELECT * FROM  tblVehicleType";

            var result = _dbConnection.Query<CarType>(query, commandType: CommandType.Text).ToList();
            return result;
        }

        public List<CarBarrackCategory> GetCarBarrackCategories()
        {
            string query = $" SELECT * FROM  tblBarrackCategories";

            var result = _dbConnection.Query<CarBarrackCategory>(query, commandType: CommandType.Text).ToList();
            return result;
        }

        public List<CarStatus> GetCarStatus()
        {
            string query = $" SELECT * FROM  tblVehicleStatus";

            var result = _dbConnection.Query<CarStatus>(query, commandType: CommandType.Text).ToList();
            return result;
        }
        public Car GetCarByPlate(string plate,string series)
        {
            string query = $" select * from Vehicle where PlateNumber = N'{plate}' And PlateSeriesNumber=N'{series}'";

            var result = _dbConnection.Query<Car>(query, commandType: CommandType.Text).FirstOrDefault();
            return result;
        }
         public CarDto GetCarByPlateWithDependency(string plate,string series)
        {
            string query = $" SELECT Vehicle.Id,dbo.tblBarrackCategories.Name AS 'BarrackCategory', Vehicle.Name AS 'VehicleName' , dbo.tblVehicleType.Name AS 'VehicleTypeName' ,tblFuelType.Name AS 'FuelTypeName' ,dbo.tblVehicleBrand.Name AS 'VehicleBrandName' , dbo.tblVehicleStatus.StatusName AS 'VehicleStatus' ,EngineNumber,ChassisNumber,PlateNumber,PlateSeriesNumber,CarCode,Created_Year,Created_At,Color,Updated_At,dbo.Vehicle.CurrentMileage,dbo.Vehicle.Image  FROM	Vehicle INNER JOIN dbo.tblBarrackCategories ON tblBarrackCategories.Id = Vehicle.BarrackCategoryId INNER JOIN dbo.tblFuelType ON tblFuelType.Id = Vehicle.FuelTypeId INNER JOIN dbo.tblVehicleBrand ON tblVehicleBrand.Id = Vehicle.VehicleBrandId INNER JOIN dbo.tblVehicleType ON tblVehicleType.Id = Vehicle.VehicleTypeId INNER JOIN dbo.tblVehicleStatus ON tblVehicleStatus.Id = Vehicle.VehicleStatusId where PlateNumber = N'{plate}' And PlateSeriesNumber=N'{series}'";

            var result = _dbConnection.Query<CarDto>(query, commandType: CommandType.Text).FirstOrDefault();
            return result;
        }

        public int InsertVehicle(Car newCar)
        {
            var procedure = "[MasterInsertUpdateDelete]";
            var values = new { Id = newCar.Id, Name = newCar.Name, VehicleTypeId = newCar.VehicletypeId, FuelTypeId = newCar.FuelTypeId, BarrackCategoryId = newCar.BarrackCategoryId, VehicleBrandId = newCar.VehicleBrandId, VehicleStatusId = newCar.VehicleStatusId, EngineNumber = newCar.EngineNumber, ChassisNumber = newCar.ChassisNumber, PlateNumber = newCar.PlateNumber, PlateSeriesNumber = newCar.PlateSeriesNumber, CarCode = newCar.CarCode, Created_Year = newCar.Created_Year, Color = newCar.Color, Created_At = newCar.Created_At, Updated_At = newCar.Updated_At, Image = newCar.Image, CurrentMileage = newCar.CurrentMileage, StatementType ="Insert"};
            var results = _dbConnection.QuerySingle<int>(procedure, values, commandType: CommandType.StoredProcedure);

            return results;
        }

        public int DeleteVehicle(Car newCar)
        {
            var procedure = "[MasterInsertUpdateDelete]";
            var values = new { Id = newCar.Id, Name = newCar.Name, VehicleTypeId = newCar.VehicletypeId, FuelTypeId = newCar.FuelTypeId, BarrackCategoryId = newCar.BarrackCategoryId, VehicleBrandId = newCar.VehicleBrandId, VehicleStatusId = newCar.VehicleStatusId, EngineNumber = newCar.EngineNumber, ChassisNumber = newCar.ChassisNumber, PlateNumber = newCar.PlateNumber, PlateSeriesNumber = newCar.PlateSeriesNumber, CarCode = newCar.CarCode, Created_Year = newCar.Created_Year, Color = newCar.Color, Created_At = newCar.Created_At, Updated_At = newCar.Updated_At, Image = newCar.Image, CurrentMileage = newCar.CurrentMileage, StatementType = "Delete" };
            int result= _dbConnection.QuerySingle<int>(procedure, values, commandType: CommandType.StoredProcedure);
            return result;
         
        }

        public byte[] ConvertImageToByteArray(Bitmap bitmap)
        {
            byte[] arrPic;
            MemoryStream ms = new MemoryStream();
            bitmap.Save(ms, bitmap.RawFormat);
            arrPic = ms.GetBuffer();
            ms.Close();
            return arrPic;
        }

        public Image ConvertByteArrayToImage(byte[] byteArrayIn)
        {
            Image returnImage = null;
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                returnImage = Image.FromStream(ms);
            }
            return returnImage;
        }

        public string UpdateVehicle(Car newCar)
        {
            var procedure = "[MasterInsertUpdateDelete]";
            var values = new { Id = newCar.Id, Name = newCar.Name, VehicleTypeId = newCar.VehicletypeId, FuelTypeId = newCar.FuelTypeId, BarrackCategoryId = newCar.BarrackCategoryId, VehicleBrandId = newCar.VehicleBrandId, VehicleStatusId = newCar.VehicleStatusId, EngineNumber = newCar.EngineNumber, ChassisNumber = newCar.ChassisNumber, PlateNumber = newCar.PlateNumber, PlateSeriesNumber = newCar.PlateSeriesNumber, CarCode = newCar.CarCode, Created_Year = newCar.Created_Year, Color = newCar.Color, Created_At = newCar.Created_At, Updated_At = newCar.Updated_At, Image = newCar.Image, CurrentMileage = newCar.CurrentMileage, StatementType = "Update" };
            var tr= _dbConnection.Query(procedure, values, commandType: CommandType.StoredProcedure);

            return "updated";
        }
    }
}
