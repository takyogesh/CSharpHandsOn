using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoMultithreading
{
    class Multithreading
    {
        public static void f1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("dell Multithreading "+(char)(i+97));
                Thread.Sleep(500);
            }
        }
        public static void f2(Object s)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(s);
                Thread.Sleep(500);
            }
        }
    }
}
