using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class InsertionSort
    {
        public static List<int> Sorted(List<int> list)
        {
            // Create copy of original list so it is not changed
            List<int> tempList = new List<int>(list);
            int tempValue;

            // Start at 1 (The first item in the list is sorted by definition)
            for (int i = 1; i < tempList.Count; i++)
            {
                int j = i;
                tempValue = tempList[j];

                while (j > 0 && tempValue < tempList[j - 1])
                {
                    tempList[j] = tempList[j - 1];
                    j--;
                }

                tempList[j] = tempValue;
            }

            return tempList;
        }
    }
}
