using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport_fleet_management_system.BL;

namespace Transport_fleet_management_system.Methods
{
    public class FuelMethods
    {
        private readonly IDbConnection _dbConnection;
        public FuelMethods(IDbConnection db)
        {
            _dbConnection = db;
        }

        public int InsertFuel(Fuel fuel)
        {
            var procedure = "[MasterInsertUpdateDeleteFuel]";
            var values = new { Id = fuel.Id, VehicleId = fuel.VehicleId, LastMileage= fuel.LastMileage, FuelTypeId = fuel.FuelTypeId, CurrentMileage = fuel.CurrentMileage, CarFunction = fuel.CarFunction, ConsumptionLiters = fuel.ConsumptionLiters, PriceOfEachLiter = fuel.PriceOfEachLiter, Price = fuel.Price, Day = fuel.Day, Month= fuel.Month, Year = fuel.Year, Comment = fuel.Comment, Liter = fuel.Liter, Created_At = fuel.Created_At, Update_At = fuel.Update_At, FactorNumber = fuel.FactorNumber, RegistereName = fuel.RegistereName, StatementType = "Insert" };
            var results = _dbConnection.QuerySingle<int>(procedure, values, commandType: CommandType.StoredProcedure);

            return results;
        }

        public List<Fuel> GetAllFuelByPlateOrderByFuelDate(int vehicleId)
        {
            var procedure = "[GetAllFuelByPlateOrderByFuelDate]";
            var values = new
            {
                VehicleId = vehicleId
            };
                var results = _dbConnection.Query<Fuel>(procedure, values,commandType: CommandType.StoredProcedure);
            return results.ToList();
        }
    }
}
