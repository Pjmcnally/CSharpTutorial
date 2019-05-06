using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> unSorted = new List<int> { 5, 10, 3, 2, 4 };
            Console.WriteLine($"Original List: {String.Join(" ", unSorted)}");

            Console.WriteLine($"BubbleSort Result: {String.Join(" ", BubbleSort.Sorted(unSorted))}");
            Console.WriteLine($"InsertionSort Result: {String.Join(" ", InsertionSort.Sorted(unSorted))}");
            Console.WriteLine($"SelectionSort Result: {String.Join(" ", SelectionSort.Sorted(unSorted))}");

            int[] array = new int[] { 1, 3, 1, 1 };
            Console.WriteLine(SelectionSort.Average(array));
        }
    }
}
