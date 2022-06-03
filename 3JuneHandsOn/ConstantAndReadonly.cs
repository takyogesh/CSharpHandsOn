using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3JuneHandsOn
{
    class ConstantAndReadonly
    {
        public const int num = 10;   // you cannot declared value in method/function
        public readonly int num1;       //the can be only initialize through the constructor only;

        public ConstantAndReadonly(int a)
        {
            num1 = a;
            Console.WriteLine("****************Consant and Readonly****************");
        }

        public void conValue()
        {
           
            Console.WriteLine(num1+" "+num);
        }
    }
}
