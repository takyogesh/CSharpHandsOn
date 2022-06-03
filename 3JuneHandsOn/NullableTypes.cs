using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3JuneHandsOn
{
    class NullableTypes
    {
        public NullableTypes()
        {
            Console.WriteLine("********************Nullable Types********************");
        }

        public void method()
        {
            Nullable<int> a = null;
            if (a.HasValue)
                Console.WriteLine(a.Value);
            else
                assignValue(a);
        }

        private void assignValue(int? a)
        {
            a = 20;
            Console.WriteLine("New value assign :"+a);
        }
    }
}
