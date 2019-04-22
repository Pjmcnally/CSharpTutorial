using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTutorials
{
    class ControlFlow
    {
        public static void ExploreIf()
        {
            int a = 5;
            int b = 3;
            int c = 4;
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }

            if ((a + b + c > 10) && (a > b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is greater than the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not greater than the second");
            }

            if ((a + b + c > 10) || (a > b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is greater than the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not greater than the second");
            }
        }

        public static void ExploreLoops()
        {
            Console.WriteLine("\r\nWhile Loop:");
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine(counter);
                counter += 1;
            }

            Console.WriteLine("\r\nFor Loop:");
            for (int index = 0; index < 10; index += 1)
            {
                Console.WriteLine(index);
            }
        }
    }
}
