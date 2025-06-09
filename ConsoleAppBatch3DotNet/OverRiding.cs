using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBatch3DotNet
{
    class RBI
    {
        public virtual void Deposite()
        {
            Console.WriteLine("Deposite Amount RBI");
        }

        public virtual void WIthdraw()
        {
            Console.WriteLine("WUthdraw Amount by RBI");
        }
    }

    // AXIS ,SBI , HDFC

    class Axis : RBI
    {
        public void MyDeposite()
        {
            Console.WriteLine("Deposite Amount");
        }

        public void MyWithdraw()
        {
            Console.WriteLine("Withdraw Amount");
        }
    }

    class SBI : RBI
    {
        public new void Deposite()
        {
            Console.WriteLine("Deposite Amount Sbi");
        }

        public override void WIthdraw()
        {
            Console.WriteLine("WUthdraw Amount by Sbi");
        }
    }
}
