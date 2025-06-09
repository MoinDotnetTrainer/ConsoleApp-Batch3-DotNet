using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBatch3DotNet
{
    class ReadonlyKeyword
    {
        const int x = 34;
        readonly public int y = 32;

        public ReadonlyKeyword()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);  // 234
        }

        public void Test()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
