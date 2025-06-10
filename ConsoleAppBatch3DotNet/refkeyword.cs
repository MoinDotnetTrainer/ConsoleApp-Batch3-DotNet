using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBatch3DotNet
{
    internal class Refkeyword
    {
        //out ket word

        //ref 

        public void Call(ref int y)  // value of X  -->121--> 10101010  --> 10
        {
            Console.WriteLine("x value is:" + y); // 2.10
            y = y + 10;
            Console.WriteLine("x value :" + y);  //3.20
        }

        public void Exe()
        {
            int x = 10;  // x addd is 0101010
            Console.WriteLine("here x is :" + x); //1.10
            Call(ref x);
            Console.WriteLine("X after call:" + x); //4.20

            // ref out 

            //const readonly

            //exe dll

            // inetrface abstract

            //

        }
    }
}
