using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedBankingSystem
{
    public class ATM
    {

      private string password;

      public void SetPassword(String pass)
        {
            password = pass;
        }
      public void SavingAccount(String pass)
        {
            if (password == pass)
            {
                //access to saving account function
                Console.WriteLine("atm working");
            }
            else
                Console.WriteLine("wrong password enter");
        }

        public void CurrentAccount(String pass)
        {
            if (password == pass)
            {
                //access to current account function
                Console.WriteLine("card working");
            }
            else
                Console.WriteLine("wrong password enter");

        }
    }
}
