using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab1
{
    // Declaring the Car() Class
    // This class has 3 properties: Color, Year, and Mileage
    public class Car
    {
        // Creates integer variable called "instances" and assigns value to 0
        private static int instances = 0;

        // Defining Properties
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        // Adding a constructor
        public Car()
        {
            // Every time the constructor runs, increment "instances"
            instances++;
        }

        // Adding another constructor
        // This constructor instantiates a Car() object while only having the color and year information
        public Car(string color, int year)
        {
            this.Color = color;
            this.Year = year;
            instances++;
        }

        // Adding another Constructor
        // This constructor instantiates a Car() object while only having the car's year and mileage information available
        public Car(int year, int mileage)
        {
            this.Year = year;
            this.Mileage = mileage;
            instances++;
        }

        // Declare static member
        public static int CountCars()
        {
            return instances;
        }

        public override string ToString()
        {
            return $"This car is painted {this.Color}, was built in {this.Year}, and has {this.Mileage} miles on it.";
        }
    }
}
