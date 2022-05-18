using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedBankingSystem
{
   public class AccountManager
    {
       
            public void SavingAccountCutomer()
            {
                SavingAccount SA = new SavingAccount();
                SA.AccountDetails("abcd", 99999999, "0123456789", 500);
                String details=SA.DisplayAccountDetails();
                 Console.WriteLine(details);
            }
            public void CurrentAccountCustomer()
            {
                CurrentAccount CA = new CurrentAccount();
                CA.AccountDetails("pqrs", 00011122333, "9976543210", 2000);
                CA.AtmRequest(true);
            CA.AtmObj.SetPassword("1234");
            CA.AtmObj.SavingAccount("1234");
            //access the atm object and set password.
            }
      
      
    }
}
