using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBatch3DotNet
{
    internal class Prop
    {
        // alwsys declares using property --> hiding the actual var an expo alias

        //public or Private or Protected



        private int x;  // x conatain address , ref 
        public int x_ // not a var , prop donst a address
        {
            get { return x; }
            set
            {

                if (value < 0 || value > 50)
                {
                    throw new ArgumentException("Value is more then the range");
                }
                else
                {
                    x = value;
                }
            }
        }

        private int y;

        public int y_
        {
            get { return y; }
            set
            {
                if (value < 0 || value > 50)
                {
                    throw new ArgumentException("Value is more then the range");
                }
                else
                {
                    y = value;
                }
            }
        }

        public void Add()
        {
            int z = x + y;  // max is 100 p1 50 , p2 50 , --> 55 +45
            Console.WriteLine("Add is:" + z);
        }

    }


    class PropforArray
    {
        private int[] Age = new int[3];

        // indexers to assign a value

        public int this[int index]
        {
            set
            {
                if (index >= 0 && index < Age.Length)
                {
                    if (value > 18)
                    {
                        Age[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Age");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Index");
                }
            }

            get
            {
                return Age[index];
            }
        }

        public void Test() {
            foreach (var item in Age)
            {
                Console.WriteLine(item);
            }
        }
    }
}
