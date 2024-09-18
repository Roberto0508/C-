using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch.MergeSort
{
    class MergeSort
    {
        static void merge(int[] a, int from, int mid, int to)
        {
            int n = to - from + 1; 
            int[] b = new int[n];

            int i1 = from;
            // Взима следващият елемент от първата половина на масива
            int i2 = mid + 1;
            // Взима следващият елемент от втората половина на масива
            int j = 0;

            while (i1 <= mid && i2 <= to)
            {
                if (a[i1] < a[i2])
                {
                    b[j] = a[i1];
                    i1++;
                }
                else
                {
                    b[j] = a[i2];
                    i2++;
                }
                j++;
            }

            // Копират се всички останали записи от първата половина на масива
            while (i1 <= mid)
            {
                b[j] = a[i1];
                i1++;
                j++;
            }
            // Копират се всички останали записи от втората половина на масива
            while (i2 <= to)
            {
                b[j] = a[i2];
                i2++;
                j++;
            }

            // Тук копираме всичко от временния масив
            for (j = 0; j < n; j++)
            {
                a[from + j] = b[j];
            }
        }

        static public void merge_sort(int[] a, int from, int to)
        {
            if (from == to) { return; }
            int mid = (from + to) / 2;
            // Сортират се първата и втората половина
            merge_sort(a, from, mid);
            merge_sort(a, mid + 1, to);
            merge(a, from, mid, to);
        }
    }
}
