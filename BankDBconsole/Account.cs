using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BankDBconsole
{
   public class Account
    {
        public string addAccount()
        {
            Console.Write("Enter ID\t:");
            int acctID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter accoount numbere\t:");
            string acctNum = Console.ReadLine();
            Console.Write("Enter Branch Name\t:");
            string branchName = Console.ReadLine();
            Console.Write("Enter City\t:");
            string city = Console.ReadLine();
           
            SqlConnection connection = new SqlConnection(Emplyoee.sqlrequest);
            //insert into employee values(1,'0001155544445','Sbi Main','jalgaon');
            SqlCommand command = new SqlCommand("Insert into account values(" + acctID + ",'" + acctNum + "','" + branchName + "','" + city + "')", connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return "Account Succefully added";
        }
    }
}
