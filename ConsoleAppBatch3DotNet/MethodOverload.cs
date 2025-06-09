using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBatch3DotNet
{
    class MethodOverload
    {
        public void M1()
        {

        }
        public void M1(int x)
        {

        }
        public void M1(string x)
        {

        }
        public void M1(int x, int y)
        {

        }
        public void M1(string x, int y)
        {

        }
        public int M1(int x, string y)
        {
            return  1;
        }
    }
}
