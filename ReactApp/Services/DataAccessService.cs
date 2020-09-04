using Microsoft.AspNetCore.Mvc.DataAnnotations;
using ReactApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactApp.Services
{
    public class DataAccessService
    {
        private DatabaseService DatabaseService { get; set; }

        public DataAccessService(DatabaseService databaseService)
        {
            DatabaseService = databaseService;
        }

        public async Task<CarModel> GetCar(int id)
        {
            var cmd = DatabaseService.CreateCommand();
            cmd.CommandText = @"SELECT * FROM cars WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            using(var reader = await cmd.ExecuteReaderAsync())
            {
                while (await reader.ReadAsync())
                {
                    return new CarModel()
                    {
                        Id = reader.GetFieldValue<int>(0),
                        Plate = reader.GetFieldValue<string>(1),
                        Maker = reader.GetFieldValue<string>(2),
                        Model = reader.GetFieldValue<string>(3),
                        Mileage = reader.GetFieldValue<int>(4),
                        Description = reader.GetFieldValue<string>(5),
                        Imported = reader.GetFieldValue<bool>(6)
                    };
                }
            }
            return null;
        }
        public async Task<CarModel> GetCar(string plate)
        {
            var cmd = DatabaseService.CreateCommand();
            cmd.CommandText = @"SELECT * FROM cars WHERE plate = @plate";
            cmd.Parameters.AddWithValue("@id", plate);

            using (var reader = await cmd.ExecuteReaderAsync())
            {
                while (await reader.ReadAsync())
                {
                    return new CarModel()
                    {
                        Id = reader.GetFieldValue<int>(0),
                        Plate = reader.GetFieldValue<string>(1),
                        Maker = reader.GetFieldValue<string>(2),
                        Model = reader.GetFieldValue<string>(3),
                        Mileage = reader.GetFieldValue<int>(4),
                        Description = reader.GetFieldValue<string>(5),
                        Imported = reader.GetFieldValue<bool>(6)
                    };
                }
            }
            return null;
        }

    }
}
