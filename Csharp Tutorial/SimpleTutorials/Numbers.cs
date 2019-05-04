using System;
using System.Numerics;

namespace SimpleTutorials
{
    class Numbers
    {
        static public void WorkingWithIntegers()
        {
            Console.WriteLine($"\r\nRunning method: {System.Reflection.MethodBase.GetCurrentMethod().Name}");
            int a = 21;
            int b = 6;
            Console.WriteLine($"Numbers: {a}, {b}");
            Console.WriteLine($"Addition: {a + b}");
            Console.WriteLine($"Subtraction: {a - b}");
            Console.WriteLine($"Multiplication: {a* b}");
            Console.WriteLine($"Division: {a / b}");
            Console.WriteLine($"Remainder: {a % b}");
        }

        static public void OrderPrecedence()
        {
            Console.WriteLine($"\r\nRunning method: {System.Reflection.MethodBase.GetCurrentMethod().Name}");
            int a = 5;
            int b = 4;
            int c = 2;
            Console.WriteLine(a + b * c);
            Console.WriteLine((a + b) * c);
            Console.WriteLine((a + b) - 6 * c + (12 * 4) / 3 + 12);

            int e = 7;
            int f = 4;
            int g = 3;
            int h = (e + f) / g;
            Console.WriteLine(h);
        }

        static public void IntegerLimits()
        {
            Console.WriteLine($"\r\nRunning method: {System.Reflection.MethodBase.GetCurrentMethod().Name}");
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min:n0} to {max:n0}");

            Console.WriteLine($"An example of overflow: {max + 3}");
        }

        static public void WorkingWithDoubles()
        {
            Console.WriteLine($"\r\nRunning method: {System.Reflection.MethodBase.GetCurrentMethod().Name}");
            double a = 5;
            double b = 4;
            Console.WriteLine(a / b);

            Console.WriteLine($"The range of double is {double.MaxValue} to {double.MinValue}");

            // In the code below G is the "General" number format. 99 is a precision specifier
            Console.WriteLine($"{1.0 / 3.0:G99}");  // Not infinitely repeating
            Console.WriteLine($"{.1 + .2:G99}");    // Double precision floating point
        }

        static public void WorkingWithDecimals()
        {
            Console.WriteLine($"\r\nRunning method: {System.Reflection.MethodBase.GetCurrentMethod().Name}");

            Console.WriteLine($"The range of double is {decimal.MaxValue:n0} to {decimal.MinValue:n0}");

            // In the code below G is the "General" number format. 99 is a precision specifier
            Console.WriteLine($"{1.0m / 3.0m:G99}");  // Not infinitely repeating
            Console.WriteLine($"{.1m + .2m:G99}");  // These are decimal numbers
        }

        public static BigInteger FibonacciBigInt(int num)
        {
            BigInteger small = 0;
            BigInteger big = 1;
            BigInteger temp = 0;

            if (num == 0)
            {
                big = 0;
            }
            else
            {
                for (int i = 1; i < num; i++)
                {
                    temp = big;
                    big = small + big;
                    small = temp;
                }
            }

            return big;
        }
    }
}
