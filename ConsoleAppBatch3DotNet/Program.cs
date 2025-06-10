using System;
using ClassLibrary1;

namespace ConsoleAppBatch3DotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! Batch 3");

            // Sample obj = new Sample();
            // obj.Test();


            /*
             * Class1 class1 = new Class1();
            class1.test();
            gfg
            hjhgj
            ghjghj
            ghj
             */


            // DataTypes obj = new DataTypes();
            // obj.Test();

            //  Readline obj = new Readline();
            // obj.Test();

            // ArraysExample obj = new ArraysExample();
            //  obj.Test();

            // Control c = new Control();
            //  c.Test();


            //ClassExample obj = new ClassExample();
            //obj.Add();
            //obj.Sub();
            //obj.Mul();
            //obj.Div(12,2);

            /* ReturnType obj = new ReturnType();
             obj.Add();
             int x = ReturnType.Sub();
             if (x == 0)
             {
                 Console.WriteLine("if ");
             }
             else
             {
                 Console.WriteLine("Else");
             }

             ReturnType.Test();
            */

            /*    Constr obj = new Constr("12");
                obj.add();
                Constr.sub();
                */

            //ReadonlyKeyword obj = new ReadonlyKeyword();


            //obj.Test();

            /* MultiplereturnType obj = new MultiplereturnType();
             (int x, string y)  = obj.Test();
             Console.WriteLine(x);
             Console.WriteLine(y);

             obj.Calculation(12, 2, out int Add, out int sub);
             Console.WriteLine(Add);
             Console.WriteLine(sub);

             obj.M3(23);
             obj.M4(2);
            */

            // Employee obj = new Employee();
            // obj.M1();


            // GP gp = new GP();
            //gp.Add();

            // ConstrChaining obj = new ConstrChaining("hi");

            //TestChild obj = new TestChild();
            //obj.Add(12,23);
            //obj.Sub();

            //RBI obj = new RBI();
            //obj.Deposite();
            //obj.WIthdraw();

            //Axis axis = new Axis();
            //axis.MyDeposite();
            //axis.MyWithdraw();



            //   ExceptionHandling obj = new ExceptionHandling();
            //  obj.Div();

            //Emp obj = new Emp();
            //obj.AllEMpData();
            //obj.AllEmpSal();

            //ProjectData obj1 = new ProjectData();
            //obj1.Sampel();

            //Refkeyword obj = new Refkeyword();
            // obj.Exe();


            //try
            //{
            //    Prop obj = new Prop();
            //    obj.x_ = 45;
            //    obj.y_ = 45;
            //    obj.Add();

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //PropforArray obj = new PropforArray();
            //obj[0] = 22;
            //obj[1] = 33;
            //obj[2] = 44;
            //Console.WriteLine(obj[0]);

            /*Delegates d = new Delegates();


            Call1 c1 = new Call1(d.Add);
            c1.Invoke();
            Call1 c2 = new Call1(d.Sub);
            c2.Invoke();

            Call2 c3 = new Call2(Delegates.Mul);
            c3 += new Call2(Delegates.Div);
            c3.Invoke(12, 2);

            // single cast and Multi cast
            */

            Point p = new Point(Annomous.Add);
            var res = p.Invoke(12, 2);
            Console.WriteLine(res);

            Point p1 = delegate (int x, int y) // annomous
            {
                return x + y;
            };
            int res1 = p1.Invoke(12, 2);
            Console.WriteLine(res1);

            Point p3 = (x, y) =>
            {
                return x + y;
            };
            int res3 = p3.Invoke(12, 2);
            Console.WriteLine(res3);
        }
    }
}
