using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3JuneHandsOn
{
    class CheckAndUncheck
    {
        public CheckAndUncheck()
        {
            Console.WriteLine("****************CheckAndUncheck*****************");
        }

        public void check(String s)
        {
            unchecked
            {
                int n = s.Length+int.MaxValue;
                Console.WriteLine(n);
            }
        } 
        public void Uncheck(String s)
        {
            checked
            {
               foreach(char ch in s)
                {
                    Console.Write(ch + " ");
                }
            }
        }
    }
}
