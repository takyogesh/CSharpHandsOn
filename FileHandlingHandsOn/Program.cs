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
          // networkLogObj.printMyData();
            networkLogObj.success();
            Console.WriteLine();
            networkLogObj.dialled();
            Console.WriteLine();
            networkLogObj.missed();
            Console.WriteLine();
            networkLogObj.failed();

            Console.Read();
        }
    }
}
