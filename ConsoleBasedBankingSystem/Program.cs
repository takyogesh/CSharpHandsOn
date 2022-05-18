using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedBankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            AccountManager am = new AccountManager();
            am.SavingAccountCutomer();
            am.CurrentAccountCustomer();
            */

            Console.WriteLine("enter the cutomer details");
            Console.Write("Enter the name ");
            String name = Console.ReadLine();
            Console.Write("Enter the Account number ");
            int AcctNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Mobile number ");
            String PhNum= Console.ReadLine();

            Console.WriteLine("cutomer details are");
            Console.WriteLine("Customer name : " + name);
            Console.WriteLine("Customer Account number : " + AcctNum);
            Console.WriteLine("Customer Mobile number : " + PhNum);

            Console.Read();
        }
    }
}
