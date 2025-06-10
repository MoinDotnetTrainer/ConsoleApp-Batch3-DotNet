using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBatch3DotNet
{
    internal class ISAS
    {
        public static void IS()
        {
            //used to chk the compatibilty of a datatype
            string x = "10";
            if (x is string)  // boolean value
            {
                Console.WriteLine("Yes x is String");
            }
            else {
                Console.WriteLine("No its not string");
            }
        }

        public static void As()
        {
            object[] arr = { 12,"HI",23.34,"Test",true};

            for (int i = 0; i < arr.Length; i++) {
                //as keyword
                string str = arr[i] as string;

                if (str != null)
                {
                    Console.WriteLine(str);
                }
                else
                {
                    Console.WriteLine("No Info");
                }
            }
        }

        public static void StringMethods() {
            //string s1 = "Hello ";
            //string s2 = (String)s1.Clone();
            //Console.WriteLine(s1);
            //Console.WriteLine(s2);


            //string s1 = "Hello ";
            //string s2 = "C#";
            //Console.WriteLine(string.Concat(s1, s2));

            //string s1 = "Hello ";
            //string s2 = "He";
            //string s3 = "Hi";
            //Console.WriteLine(s1.Contains(s2));  //true
            //Console.WriteLine(s1.Contains(s3)); //false

            //string s1 = "Hello";
            //string s2 = "Hello";
            //string s3 = "He";
            //Console.WriteLine(s1.Equals(s2)); //true
            //Console.WriteLine(s1.Equals(s3));  //false

            //string s1 = "Hello C#";
            //Console.WriteLine(s1.GetType());

            //float f = 23.34f;
            //Console.WriteLine(f.GetType());   //  To single

            //string s1 = "Hello C#";
            //string s2 = "";
            //bool b1 = string.IsNullOrEmpty(s1);  // false
            //bool b2 = string.IsNullOrEmpty(s2);  //true
            //Console.WriteLine(b1);
            //Console.WriteLine(b2);

            string s1 = "Hel;lo C Sharp";
            string[] s2 = s1.Split(';');
            foreach (string s3 in s2)
            {
                Console.WriteLine(s3);
            }
        }
    }
}
