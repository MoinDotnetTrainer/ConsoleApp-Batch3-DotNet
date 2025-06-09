using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBatch3DotNet
{
    class ClassExample
    {
        public void Add()  
        {
            int x = 45, y = 45, z;
            z = x + y;
            Console.WriteLine($"Add is {z}");
        }
        public  void Sub()  // static Method
        {
            int x = 45, y = 45, z;
            z = x - y;
            Console.WriteLine($"Sub is {z}");
        }
        public void Mul()
        {
            Console.WriteLine("Enter X");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y");
            int y = int.Parse(Console.ReadLine());
            int z = x * y;
            Console.WriteLine($"Mul is {z}");
        }
        public void Div(int x, int y)
        {
            int z;
            z = x / y;
            Console.WriteLine($"Div is {z}");
        }
    }



}
