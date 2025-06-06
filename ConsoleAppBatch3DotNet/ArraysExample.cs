using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBatch3DotNet
{
    internal class ArraysExample
    {
        public void Test()
        {
            // index of array 0, zero
            int[] arr = { 34, 4, 45, 45, 56, 56, 67, 68, 78, 7, 98, 98, 09, 09 };
            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine(arr[i]);
            }


            int[] arr1 = new int[5] { 34, 4, 565, 667, 56 };

            string[] str = { "Hi", "hello", "tets" };

            // var dynmaic & object

            object[] obj = { 34, true, "test", 34.45 };
            Console.WriteLine(obj[1]);

            // diff type of arrays 
            // 1d multi ple , jagged array

            int[,] arr2d = { { 23, 34 }, { 35, 45 } };
        }
    }
}
