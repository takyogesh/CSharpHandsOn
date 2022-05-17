using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsBasicConsole
{
    public abstract class AbstractClass
    {
        public abstract void sum();
        public abstract void sub();
    }

    public class BaseClass : AbstractClass
    {
        public override void sub()
        {
            Console.WriteLine("SubFun");
        }

        public override void sum()
        {
            Console.WriteLine("SumFun");
        }
    }

}
