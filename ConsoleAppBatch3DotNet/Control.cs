using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBatch3DotNet
{
    internal class Control
    {
        public void Test()
        {
            int x = 343, y = 2335, z = 34;
            if (x > y && x > z) // true
            {
                Console.WriteLine("x is Greater");
            }
            else if (y > x && y > z) {
                Console.WriteLine("y is Greater");
            }
            else
            {
                Console.WriteLine("y is Greater");
            }

            // for while do while

            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
