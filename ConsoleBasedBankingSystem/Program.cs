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
            AccountManager am = new AccountManager();
            am.SavingAccountCutomer();
            am.CurrentAccountCustomer();
        }
    }
}
