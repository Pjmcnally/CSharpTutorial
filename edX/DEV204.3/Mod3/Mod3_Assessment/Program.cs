using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Average given array. Round to nearest int. Round .5 to nearest even int.
            int[] avgArray;

            avgArray = new int[] {  1, 3, 1, 1 };
            Console.WriteLine($"Array avg should be 2. Computed avg: {Average(avgArray)}");

            avgArray = new int[] { -3, 2 };
            Console.WriteLine($"Array avg should be 0. Computed avg: {Average(avgArray)}");

            avgArray = new int[] { -2, 4, -1, 6 };
            Console.WriteLine($"Array avg should be 2. Computed avg: {Average(avgArray)}");

            // Reverse all but the first and last character of a string.
            string str;

            str = "Reverse";
            Console.WriteLine(Reverse(str));

            str = "a0b c1d";
            Console.WriteLine(Reverse(str));

            // Get k-th smallest element from array
            int[] smallArray;
            int k;

            smallArray = new int[] { 2, 1, 4 };
            k = 3;
            Console.WriteLine(kSmallest(smallArray, k));

            smallArray = new int[] { 7, 2, 1, 6, 1 };
            k = 3;
            Console.WriteLine(kSmallest(smallArray, k));
        }


        public static int Average(int[] a)
        {
            int sum = 0;
            foreach (int n in a)
            {
                sum += n;
            }

            decimal res = (decimal)sum / (decimal)a.Length;
            return (int)Math.Round(res);
        }

        public static string Reverse(string s)
        {
            var temp = s.ToCharArray();
            int i = 1;
            int lastIndex = temp.Length - 1;

            while (i < lastIndex - i)
            {
                char tempChar = temp[i];
                temp[i] = temp[lastIndex - i];
                temp[lastIndex - i] = tempChar;

                i++;
            }

            return new string(temp);
        }

        public static int kSmallest(int[] a, int k)
        {
            Array.Sort(a)
            return a[k - 1];
        }
    }

}
