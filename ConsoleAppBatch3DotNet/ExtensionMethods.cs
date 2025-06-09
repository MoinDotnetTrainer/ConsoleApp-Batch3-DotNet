using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBatch3DotNet
{
    static class ExtensionMethods
    {

        public static void Add(this TestChild obj, int x, int y)
        {
            Console.WriteLine("This is Add ");
            int z = x + y;
            Console.WriteLine("Add is:" + z);
        }
        public static void Sub(this TestChild obj)
        {
            Console.WriteLine("This is Sub");
        }
    }
}
