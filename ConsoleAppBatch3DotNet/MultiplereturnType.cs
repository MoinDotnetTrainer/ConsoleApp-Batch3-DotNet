using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBatch3DotNet
{
    internal class MultiplereturnType
    {
        public void M1() { }
        public int M2()
        {
            return 1;
        }
        public (int, string) Test()
        {
            return (1, "hi");
        }
        public void Calculation(int x, int y, out int Add, out int Sub)
        {
            Add = x + y;
            Sub = x - y;
        }

        public void M3(int x, int y = 0)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        public void M4(int x, params int[] y) {
            Console.WriteLine(x);

            foreach (int item in y)
            {
                Console.WriteLine(item);
            }
        }
    }
}
