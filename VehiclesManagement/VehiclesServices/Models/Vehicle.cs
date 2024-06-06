using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesServices.Models
{
    public class Vehicle
    {
        public long Id { get; set; }
        public string PatentCar { get; set; }
        public long Type_Id { get; set; } //foreign key

        public decimal Speed { get; set; }

        public Vehicle(string patentCar, long type_Id, decimal speed)
        {
            PatentCar = patentCar;
            Type_Id = type_Id;
            Speed = speed;
        }

        public Vehicle()
        {
        }
        //Create two constructors, to have the possibility of creating the object with or without data.
    }
}
