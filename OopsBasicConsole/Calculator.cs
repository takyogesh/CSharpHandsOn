using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsBasicConsole
{
    public class Calculator
    {
       public String add;
       public  String sub;
       public String div;
       public String multi;
       
       public void Addition(int num1,int num2)
        {
            Console.WriteLine(add+": "+(num1 + num2));
        }
        public void Subtraction(int num1,int num2)
        {
            Console.WriteLine(sub+": "+(num1 - num2));
        }
        public void Division(int num1,int num2)
        {
            Console.WriteLine(div+": "+(num1 / num2));
        }
        public void Multiplication(int num1,int num2)
        {
            Console.WriteLine(multi+": "+(num1 * num2));
        }

    }
}
