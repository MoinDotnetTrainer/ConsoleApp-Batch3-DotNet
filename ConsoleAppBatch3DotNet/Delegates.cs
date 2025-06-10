using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public delegate void Call1();
public delegate int Call2(int x, int y);

namespace ConsoleAppBatch3DotNet
{
    class Delegates
    {
        public void Add()  // obj 
        {
            Console.WriteLine("Add");
        }
        public void Sub() // obj
        {
            Console.WriteLine("Sub");
        }

        public static int Mul(int x, int y)  // class name
        {
            Console.WriteLine("mul");
            return 1;
        }

        public static int Div(int x, int y) // class name
        {
            Console.WriteLine("Div");
            return 1;
        }
    }
}
