using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ads_se_ft_week5
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        // Selection Sort
        static void SelectionSort(int[] arr)
        {
            int i, j, min;
            for (i = 0; i < arr.Length; i++)
            {
                min = i;
                for (j = 0; j < arr.Length; j++)
                {
                    if (arr[j] > arr[min])
                    {
                        min = j;
                        Swap(ref arr[i], ref arr[min]);
                    }
                }
            }
        }

        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }


        // Bubble Sort

        static void BubbleSort(int[] arr)
        {
            int temp = 0;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }
        }

    }
}
