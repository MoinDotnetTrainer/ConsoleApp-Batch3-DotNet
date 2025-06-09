using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBatch3DotNet
{
    class ReturnType
    {
        public void Add()
        { 
            // Non Static Method 
            int x = 45, y = 45, z;
            z = x + y;
            Console.WriteLine("Add is :"+z);
          
        }

        public static int Sub() //static Method
        {
            int x = 45, y = 45, z;
            z = x - y;
            Console.WriteLine("sub is :" + z);
            return z;
        }

        public static string Test() {
            return "Ok";
        }
    }
}
