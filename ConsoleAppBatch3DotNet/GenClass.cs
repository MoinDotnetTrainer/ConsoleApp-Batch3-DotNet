using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBatch3DotNet
{
    internal class GenClass
    {
        public static void M1<t1>(t1 x) { }
        public static void M1<t1, t2>(t1 x, t2 y) { }
        public static void M1<t1, t2, t3>(t1 x, t2 y, t3 z) { }

    }

    class GenericClass<t1, t2>
    {
        public void M1(t1 x, t2 y) { }

        public void M2(t1 x, t2 y) { }

        public void M3(t1 x, t2 y) { }

        public void M4(t1 x, t2 y) { }

        public void M5(t1 x, t2 y) { }

      //  public void M6(t1 x, t2 y, t3 z) { }
        public void M7(t1 x) { }
    }
}
