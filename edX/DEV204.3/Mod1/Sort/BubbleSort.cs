using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class BubbleSort
    {
        public static List<int> Sorted(List<int> list)
        {
            // Create copy of original list so it is not changed
            List<int> tempList = new List<int>(list);

            // Set swapped variable to track if swap has been made this pass. If no items are swapped the list is sorted and we can stop sorting.
            bool swapped = true;

            // Set sorted index. This is the upper bound. All items past this index are sorted.
            int sorted = tempList.Count - 1;

            while (swapped)
            {
                // Reset swap to false
                swapped = false;
                for (int i = 0; i < sorted; i++)
                {
                    if (tempList[i] > tempList[i + 1])
                    {
                        // Swap items in array
                        int temp = tempList[i];
                        tempList[i] = tempList[i + 1];
                        tempList[i + 1] = temp;

                        swapped = true;
                    }
                }
                // Reduce sorted index as one more item will always be sorted per pass.
                sorted--;
            }

            return tempList;
        }

    }
}
