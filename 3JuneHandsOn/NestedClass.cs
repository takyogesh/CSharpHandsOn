using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3JuneHandsOn
{
   public class NestedClass
    {

        public class oClass
        {
            public oClass()
            {
                Console.WriteLine("*****************Nested Class*****************");
            }

            public void m1()
            {
                Console.WriteLine("method of outer class");
            }
            public class iClass
            {
                public void m2()
                {
                    Console.WriteLine("method of inner class");
                }
            }
        }
    }
}
