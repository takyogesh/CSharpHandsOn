using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDBconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Emplyoee emp = new Emplyoee();
           // Console.WriteLine(emp.addEmploye());
            Account acct = new Account();
            Console.WriteLine(acct.addAccount());
            Console.Read();

        }
    }
}
