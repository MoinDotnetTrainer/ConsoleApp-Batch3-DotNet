using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public delegate void CallT1();
public delegate int CallT2(int x , int y);
namespace ConsoleAppBatch3DotNet
{
    internal class ClassDelegate
    {
        public void T1() { Console.WriteLine("t1"); } // object

        public int T2(int x, int y) { Console.WriteLine("t2");
            return 1;
        } // object
    }
}
