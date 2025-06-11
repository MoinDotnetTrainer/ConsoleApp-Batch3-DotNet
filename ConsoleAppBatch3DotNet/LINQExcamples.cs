using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBatch3DotNet
{
    class Students
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? Branch { get; set; }
        public int Age { get; set; }
    }

    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Branch { get; set; }
        public static List<Student> GetAllStudents()
        {
            List<Student> listStudents = new List<Student>()
            {
                new Student{ID= 101,FirstName = "Preety",LastName = "Tiwary",Branch = "CSE"},
                new Student{ID= 102,FirstName = "Preety",LastName = "Agrawal",Branch = "ETC"},
                new Student{ID= 103,FirstName = "Priyanka",LastName = "Dewangan",Branch = "ETC"},
                new Student{ID= 104,FirstName = "Hina",LastName = "Sharma",Branch = "ETC"},
                new Student{ID= 105,FirstName = "Anugrag",LastName = "Mohanty",Branch = "CSE"},
                new Student{ID= 106,FirstName = "Anurag",LastName = "Sharma",Branch = "CSE"},
                new Student{ID= 107,FirstName = "Pranaya",LastName = "Kumar",Branch = "CSE"},
                new Student{ID= 108,FirstName = "Manoj",LastName = "Kumar",Branch = "ETC"},
                new Student{ID= 109,FirstName = "Pranaya",LastName = "Rout",Branch = "ETC"},
                new Student{ID= 110,FirstName = "Saurav",LastName = "Rout",Branch = "CSE"}
            };
            return listStudents;
        }
    }
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

        public void Test3()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //    var res = (from s in numbers select s).ElementAt(21);
            var res1 = (from s in numbers select s).ElementAtOrDefault(22);

            var res2 = (from s in numbers select s).FirstOrDefault(x => x > 50);

            // var res3 = (from s in numbers select s).Single(x => x >= 8);

            List<int> numbers1 = new List<int>() { };


            var resultQS = (from num in numbers1
                            select num).DefaultIfEmpty();


            foreach (var item in resultQS)
            {
                // Console.WriteLine(item);
            }


            List<int> takeexample = new List<int>() { 6, 23, 445, 56, 56, 7, 87, 87, 8, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var res = (from s in takeexample select s).SkipWhile(x => x >= 6);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }

        public void Test4()
        {
            List<int> intList = new List<int>() { 10, 45, 35, 29, 100, 69, 58, 50 };
            var res = from s in intList orderby s descending select s;
            foreach (var item in res)
            {
                //  Console.WriteLine(item);
            }


            var myres = from s in Student.GetAllStudents() orderby s.FirstName select s;



            var MS = Student.GetAllStudents()
                            .OrderBy(x => x.FirstName)
                            .ThenBy(y => y.LastName)

                            .ToList();
            foreach (var item in MS)
            {
                Console.WriteLine($"Id  is {item.ID} , Name is {item.FirstName} , Lst Name is {item.LastName}, Branch is {item.Branch}");

            }

        }

        public void Test5()
        {
            List<Students> students = new List<Students>()
 {
     new Students { ID = 1001, Name = "Preety", Gender = "Female", Branch = "CSE", Age = 20 },
     new Students { ID = 1002, Name = "Snurag", Gender = "Male", Branch = "ETC", Age = 21  },
     new Students { ID = 1003, Name = "Pranaya", Gender = "Male", Branch = "CSE", Age = 21  },
     new Students { ID = 1004, Name = "Anurag", Gender = "Male", Branch = "CSE", Age = 20  },
     new Students { ID = 1005, Name = "Hina", Gender = "Female", Branch = "ETC", Age = 25 },
     new Students { ID = 1007, Name = "santosh", Gender = "Male", Branch = "CSE", Age = 22  },
     new Students { ID = 1008, Name = "Tina", Gender = "Female", Branch = "CSE", Age = 20  },
     new Students { ID = 1009, Name = "Celina", Gender = "Female", Branch = "ETC", Age = 26 },
     new Students { ID = 1010, Name = "Sambit", Gender = "Male",Branch = "ETC", Age = 35 }

 };

            var m1 = from s in students where s.Age >= 25 select s;  //lazy

            var m2 = (from s in students where s.Age >= 25 select s).Count();//immedit



            foreach (var item in m1)  // 4 names
            {
                // Console.WriteLine($"Id  is {item.ID} , Name is {item.Name} , Gender is {item.Gender}, Branch is {item.Branch},Age is {item.Age}");
            }

            // Console.WriteLine(m2);  // count 3 



            var res = from s in students group s by s.Age;  // lazy

            var GroupByQS = (from std in students
                             select std).ToLookup(x => x.Age);  // immediate


            students.Add(new Students { ID = 1011, Name = "test", Gender = "Male", Branch = "ETC", Age = 40 });



            Console.WriteLine("Group");
            foreach (var item in res)
            {
                Console.WriteLine(item.Key);
                foreach (var Data in item)
                {
                    Console.WriteLine($"Id  is {Data.ID} , Name is {Data.Name} , Gender is {Data.Gender}, Branch is {Data.Branch}");
                }
            }


            Console.WriteLine("lookup");

            foreach (var item in GroupByQS)
            {
                Console.WriteLine(item.Key);
                foreach (var Data in item)
                {
                    Console.WriteLine($"Id  is {Data.ID} , Name is {Data.Name} , Gender is {Data.Gender}, Branch is {Data.Branch}");
                }
            }


        }


        public void Test6()
        {


            IEnumerable<Student> ienum = from std in Student.GetAllStudents()
                                         where std.Branch == "CSE"
                                         select std;


            // select * from tblname where email="xyz@yahoo.com"  // 100 

            //Linq Query to Fetch all students with Gender Male
            IQueryable<Student> iquer = Student.GetAllStudents().AsQueryable()
                                .Where(std => std.Branch == "CSE");


            foreach (var item in iquer)
            {
                Console.Write(item.FirstName + " ");
            }
        }
    }
}
