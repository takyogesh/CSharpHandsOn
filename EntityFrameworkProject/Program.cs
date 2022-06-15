using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bankDBEntities bankDB = new bankDBEntities();

            //to add info into account table
            //bankDB.accounts.Add(new account(104,"5556667772","sihor","Indore"));
            //bankDB.SaveChanges();

            //to view all table data
            var acctList=bankDB.accounts.ToList();
            foreach(var l in acctList)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine();

            //bankDB.employees.Add(new employee(105, "parag", "parag@123", "6668889991", "Yawal"));
            //bankDB.SaveChanges();
            var empList = bankDB.employees.ToList();
            foreach (var l in empList)
            {
                Console.WriteLine(l);
            }
            Console.Read();
        }
    }
}
