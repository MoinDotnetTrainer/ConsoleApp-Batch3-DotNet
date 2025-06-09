using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBatch3DotNet
{
    class ConstrChaining
    {
        public ConstrChaining()
        {
            Console.WriteLine("Default Constr");
        }

        public ConstrChaining(int x) : this()
        {
            Console.WriteLine("1 int Constr");
        }

        public ConstrChaining(string x) : this(12)
        {
            Console.WriteLine("1 string Constr");
        }
    }
    class TestChild : ConstrChaining
    {
        //public TestChild() //: base()
        //{
        //    Console.WriteLine("Child Constr");
        //}
    }
}
