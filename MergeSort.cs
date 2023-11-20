using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16Day11
{
    public class MergeSort
    {
        public static void Sort(int[] arr)
        {
            Sort(arr, 0, arr.Length - 1);
        }
        private static void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                Sort(arr, left, mid);
                Sort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }
        private static void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;
            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];
            Array.Copy(arr, left, leftArray, 0, n1);
            Array.Copy(arr, mid + 1, rightArray, 0, n2);
            int i = 0;
            int j = 0;
            int k = left;
            while (i < n1 && j < n2)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArray[j];
                    j++;
                }
                k++;
            }


            while (i < n1)
            {
                arr[k] = leftArray[i];
                i++;
                k++;
            }


            while (j < n2)
            {
                arr[k] = rightArray[j];
                j++;
                k++;
            }

        }
        public static void Print(int[]arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine("\n");
        }
    }
}
