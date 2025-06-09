using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBatch3DotNet
{

    class Results
    {
        public virtual void StdResults()
        {

        }
    }
    interface Subject
    {
        void English();
        void Maths();
        public void M1() { }
    }

    interface Lang
    {
        void SecondLang();
    }

    class Exams : Subject, Lang
    {

        // public override void StdResults() { }
        public void English() { }
        public void Maths() { }

        public void SecondLang() { }
    }

    interface Int1
    {
        void M1();
    }
    interface Int2 : Int1
    {
        public  void M1() { }
    }
}