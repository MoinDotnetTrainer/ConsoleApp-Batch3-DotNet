using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBatch3DotNet
{
    class GP
    {
        protected int x, y, z;
        protected void Add()
        {
            x = 45;
            y = 45;
            z = x + y;
            Console.WriteLine("Add is :" + z);
        }
    }

    class P : GP
    {
        public void Sub()
        {
            Add();

            x = 45;
            y = 45;
            z = x - y;
            Console.WriteLine("Sub is :" + z);
        }
    }

    class C : P
    {
        public void Mul()
        {
            Add();
            x = 45;
            y = 45;
            z = x * y;
            Console.WriteLine("Mul is :" + z);
        }
    }
}
