using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3JuneHandsOn
{
    class MethodHiding: oldMethodHide
    {
        public MethodHiding()
        {
            Console.WriteLine("****************Method Hiding**********************");
        }

        public new void method()
        {
            Console.WriteLine("updated method");
        }
    }

    class oldMethodHide
    {
        public void method()
        {
            Console.WriteLine("old method");
        }
    }
}
