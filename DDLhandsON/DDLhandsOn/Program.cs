using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EBBill;
namespace DdlHandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            Ebill e = new Ebill();
            e.CustomerData(101, "amar", 10);
            e.CustomerData(102, "rahul", 9);
            e.CustomerData(103, "akshay", 27);
            e.CustomerData(104, "vinay", 12);
            e.CustomerData(105, "ankit", 32);
            e.CustomerData(106, "yogi", 18);
            e.CustomerData(107, "ramesh", 21);
            e.CustomerData(108, "suresh", 19);
            e.CustomerData(109, "akash", 13);
            TOP:
            Console.WriteLine("choose the option: \n 1 for Customer detalis \n 2 for show EBbill \n 3 for all bill report\n");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    {
                        Console.WriteLine("Enter customer id to view details");
                        int id = Convert.ToInt32(Console.ReadLine());
                        e.ShowCustomerDetails(id);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter customer id to view details");
                        int id = Convert.ToInt32(Console.ReadLine());
                        e.ShowCustomerDetails(id);
                        break;
                    }
                case 3:
                    {
                        e.ShowEbBillReport();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("choose correct option");
                        goto TOP;
                    }
            }
            Console.Read();

        }
    }
}
