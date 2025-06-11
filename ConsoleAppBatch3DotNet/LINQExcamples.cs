using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBatch3DotNet
{

    class Batch3
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Gender { get; set; }
    }
    class Batch1
    {
        public int ID { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }

    internal class LINQExcamples
    {
        public void Test()
        {
            int[] arr = { 34, 34, 5, 45, 6, 576, 7, 8, 98, 9, 9, 0, 9, 0, 23, 34, 45, 45, 6 };

            foreach (var item in arr)
            {
                //Console.WriteLine(item);
            }

            // Query SYntax to Get the data from Source
            // query , method synatx
            var res = from s in arr select s;  // mauplate , filtering or searching

            var res1 = from s in arr where s > 50 select s;

            // Select * from TbleName

            foreach (var item in res1)
            {
                // Console.WriteLine(item);
            }

            List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            var myres = from s in integerList where s > 5 select s;

            var QuerySyntax = integerList.Where(obj => obj > 5).ToList();
            foreach (var item in QuerySyntax)
            {
                //  Console.WriteLine(item);
            }

            List<Batch3> obj = new List<Batch3>() {
            new Batch3{ ID=1,Name="Bhuvana",Age=22,Gender="Female"},
            new Batch3{ ID=2,Name="Moin",Age=25,Gender="Male"},
            new Batch3{ ID=3,Name="Ramu",Age=45,Gender="Female"},
            new Batch3{ ID=4,Name="Sunil",Age=34,Gender="Female"},
            new Batch3{ ID=5,Name="Supriya",Age=43,Gender="Female"},
            };

            var mydata = from s in obj select s;
            var mydata1 = from s in obj where s.Gender == "Female" select s;
            var mydata2 = from s in obj where s.Age > 30 select s;
            var mydata3 = from s in obj
                          select new
                          {
                              ID = s.ID,
                              Name = s.Name
                          };


            foreach (var item in mydata3)
            {
                // Console.WriteLine($"Id is {item.ID}, Name is {item.Name},Age is ,Gender is");

            }

            List<int> integerList1 = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,   1, 2, 3, 4, 5, 6, 7, 8, 9, 10,234,45,56,4567,57
            };

            var dis = (from s in integerList1 select s).Distinct();

            foreach (var item in dis)
            {
                // Console.WriteLine(item);
            }


            List<object> list = new List<object>() {
            12,134,325,4356,46,"Hi","Hello","Hw ru",true,23.34,'C'
            };

            var specif = list.OfType<string>().ToList();
            var intData = (from num in list.OfType<int>()
                           select num).ToList();

            foreach (var item in specif)
            {
                Console.WriteLine(item);
            }


        }
        public void Test1()
        {
            List<int> dataSource1 = new List<int>() { 1, 2, 3, 4, 5, 6, 23, 4, 34, 45, 45 };
            List<int> dataSource2 = new List<int>() { 1, 3, 5, 8, 9, 10, 45, 6, 75, 86, 86, 7 };
            var res = (from s in dataSource1 select s).Except(dataSource2).ToList();
            foreach (var item in res)
            {
                // Console.WriteLine(item);
            }

            var total = (from s in dataSource2 select s).Average();
            //  Console.WriteLine(total);
        }

        public void Test2()
        {
            List<int> dataSource1 = new List<int>() { 1, 2, 3, 4, 5, 6, 23, 4, 34, 45, 45 };

            var res = (from s in dataSource1 select s).Contains(223);

            var res1 = (from s in dataSource1 select s).Any(x => x == 10); // true

            var res2 = (from s in dataSource1 select s).All(x => x > 0); // false

            // ID ,Name Email , Status , Phone Number
            // from s in Data 


            //Console.WriteLine(res2);

            List<Batch1> list = new List<Batch1>() {
            new Batch1{ ID=1,Email="Kamali",Password="123"},
            new Batch1{ ID=2,Email="Heena",Password="123"},

            };

            var login = (from s in list select s).All(x => x.Email == "Kamali" && x.Password == "123");
            Console.WriteLine(login);
        }
    }
}
