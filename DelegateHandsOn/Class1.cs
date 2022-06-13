using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHandsOn
{
    delegate void message(string msg);
    class Class1
    {
        public void Hello(string msg)
        {
            Console.WriteLine(msg);
        }
        public void Hii(string msg)
        {
            Console.WriteLine(msg);
        }
        public void Gm(string msg)
        {
            Console.WriteLine(msg);
        }


    }
}
