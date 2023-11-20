using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16Day11
{
    internal class Program
    {
        public static void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }
        private static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right);
                QuickSort(array, left, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, right);
            }

        }
        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                }

            }
            Swap(array, i + 1, right);
            return i + 1;
        }
        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];

            Console.WriteLine("Enter the element in the arraay");
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Orginal array");
            Print(array);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            QuickSort(array);
            stopwatch.Stop();
            Console.WriteLine("After quick sort");
            Print(array);
            Console.WriteLine($"ArraySize {array.Length} Time Taken {stopwatch.Elapsed.TotalMilliseconds} miliseconds");
            Console.WriteLine("\n");

             

            Console.WriteLine("Merge sort start here");
            int n;
            Console.WriteLine("Enter the size of array");
            n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            Console.WriteLine("Enter the element in array");
            for(int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            
  
            Stopwatch mergeSortStopwatch = new Stopwatch();
            MergeSort.Print(arr1);
            mergeSortStopwatch.Restart();
            MergeSort.Sort(arr1);
            mergeSortStopwatch.Stop();
            Console.WriteLine();
            MergeSort.Print(arr1);
            Console.WriteLine($"Array Size: {array.Length}, Time Taken for MergeSort: {stopwatch.Elapsed.TotalMilliseconds} milliseconds");
            Console.ReadKey();

        }
    }
}
