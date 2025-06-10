using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate int Point(int x, int y);

namespace ConsoleAppBatch3DotNet
{
    internal class Annomous
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
