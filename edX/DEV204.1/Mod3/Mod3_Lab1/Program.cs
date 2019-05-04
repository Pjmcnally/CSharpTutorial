using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 40;
            int c = 13;
            int res;
            
            res = Sum(a, b);
            Console.WriteLine($"Calling sum with 2 arguments: The sum of {a} and {b} is: {res}");

            res = Sum(a, b, c);
            Console.WriteLine($"Calling sum with 3 arguments: The sum of {a}, {b}, and {c} is: {res}");

            double e = 155.7;
            double f = -37.2;
            double dblRes = Sum(e, f);
            Console.WriteLine($"Calling sum with 2 arguments: The sum of {e} and {f} is: {dblRes}");
        }

        // Sum() method that takes two integer arguments and sums them
        // The method returns no value which is why we use void
        // We also need to use static in the method signature because Main is static
        // and you cannot call a non-static method from a static method
        static int Sum(int first, int second)
        {
            int sum = first + second;
            return sum;
        }

        // Sum() method that takes three integer arguments and sums them
        // and then returns the value
        // This method uses the same name as the Sum() method that takes two integers
        // but the parameters here indicate the method is expecting three integers as arguments
        // The compiler knows which method to call based on the number of arguments passed in
        static int Sum(int first, int second, int third)
        {
            int sum = first + second + third;
            return sum;
        }

        // Sum() method that takes two doubles as arguments
        // This method uses the same name as the Sum() method that takes two integers
        // but the parameters here indicate the method is expecting two doubles as arguments
        // The compiler knows which method to call based on the arguments data types
        static double Sum(double first, double second)
        {
            double result = first + second;
            return result;
        }

    }
}
