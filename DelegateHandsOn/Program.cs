using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHandsOn
{
    class Program
    {
        delegate int number(int n1,int n2);
        static void Main(string[] args)
        {
            Console.WriteLine("delegates with return type");
            number n = new number(multi);
            Console.WriteLine(n(10, 35));
            number n1 = new number(add);
            Console.WriteLine(n1(10, 35));

            Console.WriteLine("delegates with non-return type");

            Class1 c1 = new Class1();
            message m1 = new message(c1.Hello);
            m1("hello");
            message m2 = new message(c1.Gm);
            m2("Good morning");
            Console.Read();
        }

        public static int  add(int a, int b)
        {
            return a + b;
        } 
        public static int  multi(int a, int b)
        {
            return a * b;
        } public static int  divi(int a, int b)
        {
            return a / b;
        }
    }
}
