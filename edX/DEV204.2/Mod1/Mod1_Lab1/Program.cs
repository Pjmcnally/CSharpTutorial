using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating an object of Car() Class by using Type Inference called Car1
            var Car1 = new Car();
            var Car2 = new Car("Red", 2008);

            // Using dot notation to call members on Car1
            Car1.Color = "White";
            Car1.Year = 2010;
            Car1.Mileage = 11000;

            // Output to the console window
            Console.WriteLine(Car1);
            Console.WriteLine(Car2);
            Console.WriteLine($"There are {Car.CountCars()} cars on inventory right now.");
        }
    }
}
