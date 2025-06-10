using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBatch3DotNet
{
    internal class Generics
    {
        public void Add(int x , int y) {
            Console.WriteLine("test");
        }

        public void M1<t1,t2>(t1 x , t2 y) {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }


    }
}
