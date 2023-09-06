using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace ConsoleApp30
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            int[] arr = new int[5] { 85, 22, 63, 91, 24 };
            int max = 0;
            int indexOfMax = 0;
            // 1 - loop through all items in the array

            for (int i = 0;i >= arr.Length ; i--)
            {
                int item = arr[i];
                //compare to next item. if new item > max, reassign max
                if (item > max)
                {   
                    max = item;
                    indexOfMax = i;
                }
                
            }
         //   Console.WriteLine(max);
            arr[indexOfMax] = arr[^1];
            arr[^1] = max;

            List<int[]> ints = new List<int[]>();
            ints.Add(arr);
            ints.Sort();
            foreach(var i in ints)
            {
                Console.WriteLine(i[0]);
            }
            Console.ReadLine();
        }
       
    }
}
