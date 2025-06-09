using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBatch3DotNet
{
    abstract class Banking
    {
        //Abstrct Methods
        public abstract int Deposite(int x, int y);
        public abstract void Withdraw();
        public void Add() { }  // 1.Access thrw Child  class
        public static void Sub() { }  // Banking Class Name
        public virtual void Mul() { } // Banking obj and Override in child

        public Banking() { }  // WIth Base and Banking object
    }

    class Icici : Banking
    {
        public override int Deposite(int x, int y)
        {
            return 1;
        }

        public override void Withdraw()
        {
            Console.WriteLine("WItgdraw");
        }
    }
}
