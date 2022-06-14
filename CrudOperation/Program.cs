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
            Console.WriteLine("Press 1 for account \n Press 2 for employee");
            int i = Convert.ToInt32(Console.ReadLine());
            switch(i)
            {
                case 1:
                     Account();
                    break;
                case 2:
                     Employee();
                     break;
            }
           
            Console.Read();
        }

        private static void Employee()
        {
            Emplyoee emp = new Emplyoee();
        Repeat:
            Emenu();
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine(emp.AddEmploye());
                    goto Repeat;
                case 2:
                    Console.WriteLine(emp.UpdateEmail());
                    goto Repeat;
                case 3:
                    emp.SelectEmployeeByID();
                    goto Repeat;
                case 4:
                    Console.WriteLine(emp.DeleteEmployee());
                    goto Repeat;
                case 5:
                    emp.SelectAllEmployee();
                    goto Repeat;
                case 6:
                    break;
                default:
                    Console.WriteLine("wrong choice");
                    break;
            }
        }

        private static void Account()
        {
            Account acct = new Account();

        Repeat:
            Amenu();
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine(acct.AddAccount());
                    goto Repeat;
                case 2:
                    acct.SelectAllAccount();
                    goto Repeat;
                case 3:
                    acct.SelectAccountByID();
                    goto Repeat;
                case 4:
                    Console.WriteLine(acct.DeletedAccount());
                    goto Repeat;
                case 5:
                    Console.WriteLine(acct.UpdateCity());
                    goto Repeat;
                case 6:
                    break;
                default:
                    Console.WriteLine("wrong choice");
                    break;
            }
        }

        private static void Amenu()
        {
            Console.WriteLine("\nTo add account Press 1: ");
            Console.WriteLine("To view all Account info Press 2: ");
            Console.WriteLine("To view Indivisual Acoount info Press 3: ");
            Console.WriteLine("To delete account Press 4: ");
            Console.WriteLine("To update account Press 5: ");
            Console.WriteLine("To Exit Press 6: ");
            Console.WriteLine();
        }
        private static void Emenu()
        {
            Console.WriteLine("\nTo add emplyoee Press 1: ");
            Console.WriteLine("To update emplyoee email Press 2: ");
            Console.WriteLine("To view Indivisual emplyoee info Press 3: ");
            Console.WriteLine("To delete emplyoee record Press 4: ");
            Console.WriteLine("To view all employee info Press 5: ");
            Console.WriteLine("To Exit Press 6: ");
            Console.WriteLine();
        }
    }
}
