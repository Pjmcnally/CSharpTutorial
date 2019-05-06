using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class SelectionSort
    {
        public static List<int> Sorted(List<int> list)
        {
            // Create copy of original list so it is not changed
            List<int> tempList = new List<int>(list);

            for (int i = 0; i < tempList.Count - 1; i++)
            {
                int tempMinIndex = i;
                for (int j = i + 1; j < tempList.Count; j++)
                {
                    if (tempList[j] < tempList[tempMinIndex]) {
                        tempMinIndex = j;
                    }
                }

                var temp = tempList[i];
                tempList[i] = tempList[tempMinIndex];
                tempList[tempMinIndex] = temp;
            }

            return tempList;
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
    }
}
