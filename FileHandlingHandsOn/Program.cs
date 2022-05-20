using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingHandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            NetworkLog networkLogObj = new NetworkLog();
            networkLogObj.Read();
            Console.Read();
        }
    }
}
