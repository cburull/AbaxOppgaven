using System;
using System.Collections.Generic;

namespace AbaxOppgaven
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new()
            {
                new Car("NF123456", 147, 200, "lett kjøretøy", "grønn"),
                new Car("NF654321", 150, 195, "lett kjøretøy", "blå"),
                new Airplane("LN1234", 1000, "jetfly", 10, 2, 30),
                new Boat("ABC123", 100, 30, 500)
            };

            Console.WriteLine($"Bil 1 og 2 er {vehicles[0].SameVehicle_Text(vehicles[1])}.\n");

            vehicles[2].ShowInfo();
            vehicles[2].Start();
            vehicles[2].ShowInfo();

            vehicles[0].Start();
            vehicles[0].ShowInfo();

            vehicles[3].ShowInfo();
        }
    }
}
