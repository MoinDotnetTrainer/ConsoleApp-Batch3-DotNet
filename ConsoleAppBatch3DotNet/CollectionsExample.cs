using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBatch3DotNet
{

    class AccentureEmp
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int? Age { get; set; }
    }
    class CollectionsExample
    {
        public void ListExample()
        {
            int[] arr = { 23, 34, 35, 45, 6, 5, 67, 68, 78, 7, 89 };
            int[] arr1 = new int[2] { 12, 2 };

            foreach (var item in arr1)
            {
                // Console.WriteLine(item);
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                // Console.WriteLine(arr1[i]);
            }


            // with an array we can also Insetting an Sorting an Emelemt searching element

            // collections  --> dynamic array

            List<int> list = new List<int>();
            list.Add(12);//0
            list.Add(23);
            list.Add(23);

            list.Add(132);
            list.Add(24);
            list.Add(4);
            list.Add(5712);
            list.Add(67);
            list.Add(23);
            list.Add(23);

            list.Add(132);
            list.Add(24);
            list.Add(4);
            list.Add(5712);
            list.Add(67);
            list.RemoveAt(1);
            list.Remove(132);
            list.Insert(0, 100);
            list.Reverse();


            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            //In Looping For ,  While  , DO while 

            // foreach


            List<AccentureEmp> EMp = new List<AccentureEmp>() {
            new AccentureEmp{ ID=1, Name="Test", Email="test@yahoo.com",Age=null},
            new AccentureEmp{ ID=2, Name="Sam", Email="sam@yahoo.com",Age=34},
            new AccentureEmp{ ID=3, Name="Anu", Email="anu@yahoo.com",Age=23},
            new AccentureEmp{ ID=4, Name="xyz", Email="xyz@yahoo.com",Age=43},
            };

            foreach (var item in EMp)
            {
                //   Console.WriteLine($"Id is {item.ID} , Name is {item.Name},EMail Is {item.Email}");
            }
        }

        public void HashSet()
        {
            HashSet<int> hs = new HashSet<int>();
            hs.Add(132);
            hs.Add(24);
            hs.Add(4);
            hs.Add(5712);
            hs.Add(67);
            hs.Add(23);
            hs.Add(23);

            hs.Add(132);
            hs.Add(24);
            hs.Add(4);
            hs.Add(5712);
            hs.Add(67);
            foreach (var item in hs)
            {
                Console.WriteLine(item);
            }
        }
        public void SotrtedSet()
        {
            SortedSet<int> ss = new SortedSet<int>();
            ss.Add(132);
            ss.Add(24);
            ss.Add(4);
            ss.Add(5712);
            ss.Add(67);
            ss.Add(23);
            ss.Add(23);

            ss.Add(132);
            ss.Add(24);
            ss.Add(4);
            ss.Add(5712);
            ss.Add(67);
            foreach (var item in ss)
            {
                Console.WriteLine(item);
            }
        }

        public void Stack() // lifo
        {
            Stack<int> st = new Stack<int>();
            st.Push(12);
            st.Push(34);
            st.Push(346);

            st.Push(56);
            st.Push(324);
            st.Push(124);
            st.Push(234);
            st.Pop();
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
        }

        public void Queue() // Fifo
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(12);
            q.Enqueue(4);
            q.Enqueue(435);
            q.Enqueue(523);
            q.Enqueue(24);
            q.Enqueue(34);
            q.Enqueue(324);
            q.Enqueue(1225);
            q.Dequeue();
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }
        public void Arraylist()
        {
            ArrayList arr = new ArrayList();
            arr.Add(1);
            arr.Add("test");
            arr.Add(true);
            arr.Add(23.34);
            arr.Add('c');
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

    }
}
