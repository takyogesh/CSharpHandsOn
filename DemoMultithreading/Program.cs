using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoMultithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Multithreading.f1);
            t1.Start();
                Thread t = Thread.CurrentThread;
                t.Name = "main";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(t.Name+" "+i);
                Thread.Sleep(500);
            }
            Thread t2 = new Thread(Multithreading.f2);
            t2.Start("hi");
            Console.Read();
        }
        public static void m1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine((char)(i+65));
                Thread.Sleep(500);
            }
        }
    }
}
