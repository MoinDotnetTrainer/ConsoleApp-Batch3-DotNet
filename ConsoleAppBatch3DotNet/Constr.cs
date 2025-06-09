using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBatch3DotNet
{
    class Constr
    {
        public Constr()  // invoked auto dusing obj creation , implict or default
        {
            Console.WriteLine("any logic");
        }

        public Constr(int x)  // invoked auto dusing obj creation , expict or pm constr
        {
            Console.WriteLine("1 int");
        }
        public Constr(string x)  // invoked auto dusing obj creation
        {
            Console.WriteLine("1 string");
        }


        public void add() {  // obj
            Console.WriteLine("non static Add");
        }
        
        public static void sub() { //classname
            Console.WriteLine("Static sub");
        }
    }
}
