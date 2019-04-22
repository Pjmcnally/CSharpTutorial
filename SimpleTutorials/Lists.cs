using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Numerics;

namespace SimpleTutorials
{
    class Lists
    {
        public static void SimpleLists()
        {
            var names = new List<string> { "Patrick", "Ana", "Felipe" };
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");

            foreach (var name in names)
            {
                Console.WriteLine(name.ToUpper());
            }
        }

        public static void SearchSort()
        {
            var generator = new Random();
            var randNums = new List<int>();
            for (var i = 0; i < 1000; i += 1)
            {
                randNums.Add(generator.Next(0, 1000));
            }

            randNums.Sort();
            foreach (var num in randNums)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine(randNums.Contains(997));
        }

        public static BigInteger FibonacciList(int num)
        {
            var fibNums = new List<BigInteger> { 0, 1 };
            while (fibNums.Count() < num + 1)
            {
                int count = fibNums.Count;
                fibNums.Add(fibNums[count - 1] + fibNums[count - 2]);
            }

            return fibNums[num];
        }   
    }
}
