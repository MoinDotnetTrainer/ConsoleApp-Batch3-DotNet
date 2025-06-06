using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBatch3DotNet
{
    internal class Readline
    {
        public void Test()
        {
          /*  Console.WriteLine("Enter Ur Name");
            string Name = Console.ReadLine();  // pre define value @ runtime
            Console.WriteLine($"My Name is {Name}");


            // LHS == RHS

            Console.WriteLine("Enter ur Age");
            byte Age = Convert.ToByte(Console.ReadLine()); //34 "34"
            Console.WriteLine($"Age is {Age}");

            Console.WriteLine("Enter Salary");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Salary is {salary}");

            Console.WriteLine("Enter Bonus");
            int Bonus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Bonus AMount is {Bonus}");

            Console.WriteLine("Enter Price AMount");
            float price = float.Parse(Console.ReadLine());
            Console.WriteLine($"price is {price}");

            Console.WriteLine("Enter Status");
            bool status = bool.Parse(Console.ReadLine());
            Console.WriteLine($"Status is {status}");



            string str = null;
            //  int x = Convert.ToInt32(str); // allows null as well
            int x = int.Parse(str);  // will never allow null value
            Console.WriteLine($"x is {x}");  // 0
          */
            // try parse

            string x1 = "xyz";
            bool res = byte.TryParse(x1, out byte x2); // true
            if (res == true)
            {
                Console.WriteLine(x2); // 123
            }
            else
            {
                Console.WriteLine("No result");
            }

        }
    }
}
