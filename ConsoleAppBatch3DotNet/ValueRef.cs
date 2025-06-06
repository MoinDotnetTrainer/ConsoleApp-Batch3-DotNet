using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBatch3DotNet
{
    internal class ValueRef
    {
        public void Test()
        {
            // value type and Ref type 
            // datatype whole value is fixed --> value  example --> byte int float double decimal
            // lenth is not fixed --> for example --> object string arrays

            // value type datatype cannot null value directly

            int? x = null;
            Nullable<int> y = null;
            // we need to x as nullable
            string str = null;

            // implict & explict
            // auto , manually

            // converting the value from lower to heigher

            byte b = 100;
            int b1 = b;

            int b3 = 100;
            byte b2 = (byte)b3;


            // boxing & unboxing
            // value type to ref type

            int z = 100;
            string z1 = z.ToString();

            //unboxing
            string str1 = "100";
            int value = Convert.ToInt32(str1);





        }
    }
}
