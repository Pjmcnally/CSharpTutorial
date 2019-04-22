using System;
using System.Collections.Generic;
using System.Text;
using static tutorialApp.Strings;
using static tutorialApp.Numbers;
using static tutorialApp.ControlFlow;
using static tutorialApp.Lists;


namespace tutorialApp
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
            Console.WriteLine($"Fibonacci[{num}] = {FibonacciBigInt(num):n0}");
            Console.WriteLine($"Fibonacci[{num}] = {FibonacciList(num):n0}");

            // Class Methods
        }
    }
}
