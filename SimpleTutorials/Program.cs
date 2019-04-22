using System;
using System.Numerics;
using static SimpleTutorial.Strings;
using static SimpleTutorial.Numbers;
using static SimpleTutorial.ControlFlow;
using static SimpleTutorial.Lists;


namespace SimpleTutorial
{
    class Program
    {
        static void Main()
        {
            // Strings Methods
            //HelloWorld();
            //StringProperties();
            //StringMethods();

            // Numbers Methods
            //WorkingWithIntegers();
            //OrderPrecedence();
            //IntegerLimits();
            //WorkingWithDoubles();
            //WorkingWithDecimals();

            // ControlFlow Methods
            //ExploreIf();
            //ExploreIf();
            //ExploreLoops();

            // List Methods
            //SimpleLists();
            //SearchSort();

            // Fibonacci 
            int num = 1001;
            BigInteger addMethod = FibonacciBigInt(num);
            BigInteger listMethod = FibonacciList(num);

            Console.WriteLine($"\nAdd Method:\nFibonacci[{num}] = {addMethod:n0}");
            Console.WriteLine($"\nList Method:\nFibonacci[{num}] = {listMethod:n0}");
            Console.WriteLine($"\nAdd Method result = List method result: {addMethod == listMethod}");

            // Class Methods
        }
    }
}
