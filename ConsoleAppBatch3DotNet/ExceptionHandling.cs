using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBatch3DotNet
{
    class ExceptionHandling
    {
        // Compile time Syntax Error , & Runtime  during the execution (ubexpectdly)
        public void Div()
        {
        a:
            try
            {
                Console.WriteLine("Enter X");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter y");
                int y = Convert.ToInt32(Console.ReadLine());
                int z = x / y;
                Console.WriteLine("Div is:" + z);

                int[] arr = new int[2] { 3, 23 };
                Console.WriteLine(arr[10]);
            }
             
            catch (FormatException ex)
            {
                Console.WriteLine("Plz Enter Only Number:" + ex.Message);
                goto a;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Y cannot be zero:" + ex.Message);
                goto a;
            }
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("No elemts in that Index:" + ex.Message);
            //    goto a;
            //}
            catch (Exception ex)
            {
                Console.WriteLine("Plz Enter Only Number:" + ex.Message);
                goto a;
            }


        }
    }
}
