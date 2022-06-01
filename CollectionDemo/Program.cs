using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ListGradeBook lg = new ListGradeBook();
            lg.gradebook();
            lg.grade();
            Console.Read();
        }
    }
}
