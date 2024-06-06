using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesServices.Models;

namespace VehiclesServices.DAO
{
    public class VehiclesDAO
    {
        private IDbConnection PrepareConnection() 
        {
            string ConnectionString = "server=PCGAMINGALAN\\SQLEXPRESS; database=CarDepot; Integrated Security=true";
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }

        //create a list and bring the information from the database.
        public List<Vehicle> GetAll() 
        { 
            IDbConnection connection = PrepareConnection();
            IDbCommand command = connection.CreateCommand();
            command.CommandText = "SELECT ID, PATENT_CAR, ID_TYPE, SPEED FROM VEHICLES";

            //process
            var lector = command.ExecuteReader();
            var vehicles = new List<Vehicle>();
            while (lector.Read()) 
            {
                Vehicle vehicle = new Vehicle()
                {
                    Id = lector.GetInt32(0),
                    PatentCar = lector.GetString(1),
                    Type_Id = lector.GetInt32(2),
                    Speed = lector.GetDecimal(3)
                };
                vehicles.Add(vehicle);
            }
            connection.Close();
            return vehicles;
        }

        public void Insert(Vehicle vehicle) 
        {
            string query = $"INSERT INTO VEHICLES (PATENT_CAR, ID_TYPE, SPEED) VALUES ('{vehicle.PatentCar}', {vehicle.Type_Id}, {vehicle.Speed})";
            var connection = PrepareConnection();
            var command = connection.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();

            connection.Close();

        }

    }
}
