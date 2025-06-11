using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBatch3DotNet
{
    class WordCount
    {
        public int GetValue(string Filename)
        {
            int length = 0;

            using (StreamReader reader = new StreamReader(Filename))
            {
                // reading the content from that file
                string str = reader.ReadToEnd();
                length = str.Length;   // 343433 

                Task.Delay(5000).Wait();
            }
            return length;
        }

        public void Call()
        {
            string filname = "C:\\Users\\m.a.khaja.moinuddin\\OneDrive - Accenture\\Desktop\\notes.txt";
            int res = GetValue(filname);
            Console.WriteLine("Task 1");
            Console.WriteLine("Task 2");
            Console.WriteLine("Task 3");
            Console.WriteLine("The lenth of file is :" + res);
            Console.WriteLine("Task 4");
            Console.WriteLine("Task 5");
            Console.WriteLine("Task 6");
        }

        public async Task<int> GetValue1(string Filename)  // async method
        {
            int length = 0;

            using (StreamReader reader = new StreamReader(Filename))
            {
                // reading the content from that file
                string str = await reader.ReadToEndAsync();
                length = str.Length;   // 343433 

                Task.Delay(5000).Wait();
            }
            return length;
        }

        public async void Call1()
        {
            string filname = "C:\\Users\\m.a.khaja.moinuddin\\OneDrive - Accenture\\Desktop\\notes.txt";
            Task<int> res = GetValue1(filname);

            Console.WriteLine("Task 1");
            Console.WriteLine("Task 2");
            Console.WriteLine("Task 3");
            int lenth = await res; // awaits incidates that am on hold other can exe
            Console.WriteLine("The lenth of file is :" + lenth);
            Console.WriteLine("Task 4");
            Console.WriteLine("Task 5");
            Console.WriteLine("Task 6");
        }
    }
}
