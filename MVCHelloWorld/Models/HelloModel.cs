using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCHelloWorld.Models
{
    public class HelloModel
    {
        public static List<Car> GetCars()
        {
            List<Car> cars = new List<Car>
            {
            new Car { Id = 1, Make = "Cadillac", Model = "CTS"},
            new Car { Id = 2, Make = "Ford", Model = "Mustang" },
            new Car { Id = 3, Make = "Jeep", Model = "Cherokee" }};
            return cars;
        }
    }

    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}