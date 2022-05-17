using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsBasicConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pro = new Program();
            pro.calculate();

            int n1 = 100;
            int n2 = 50;

            Calculator calc = new Calculator();
            calc.add = "Addition";
            calc.Addition(n1, n2);
            calc.sub = "Subtraction";
            calc.Subtraction(n1, n2);
            calc.multi = "Multiplication";
            calc.Multiplication(n1, n2);
            calc.div = "Division";
            calc.Division(n1, n2);
      
            Console.Read();
        }

       void calculate()
        {
            Console.WriteLine("Calculator Function");
        }
    }
}
