using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3JuneHandsOn
{
    class Tuples
    {
        public Tuples()
        {
            Console.WriteLine("****************Tuple******************");
        }

        public void printTuple()
        {
            var dob = new Tuple<int, string, int>(24, "january", 1998);
            Console.WriteLine(dob.Item1+"/"+dob.Item2+"/"+dob.Item3);
        }
        public void input()
        {

        }
    }
}
