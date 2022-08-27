using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortDemo
{
    public class InsertionSort
    {
        public void Checksorting()
        {
            int[] arr = { 23, 9, 85, 12 };

            int n = 4, i, j, val, flag;

            for (i = 0; i < arr.Length; i++)
            {
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1; i++)
                {
                    if(val < arr[j])
                    {
                        arr[j+1] = arr[j];
                        j--;
                        arr[j+1] = val;
                    }
                    else
                    {
                        flag = 1;
                    }
                }
            }
            Console.WriteLine("Array is sorted: ");
            foreach (int p in arr)
            {
                Console.WriteLine(p);
            }
        }
    }
}
