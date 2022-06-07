using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BankDBconsole
{
    public class Emplyoee
    {
        public static string sqlrequest= "Data Source=DESKTOP-00LQG0A;Initial Catalog=bankDB;Integrated Security=True";
        public string addEmploye()
        {
            Console.Write("Enter ID\t:");
            int empID=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name\t:");
            string name= Console.ReadLine();
            Console.Write("Enter email\t:");
            string email= Console.ReadLine();
            Console.Write("Enter Phone Number\t:");
            string ph= Console.ReadLine();
            Console.Write("Enter City\t:");
            string city= Console.ReadLine();
            SqlConnection connection = new SqlConnection(sqlrequest);
            //insert into employee values(1,'yogesh','yoge@123','1234567899','jalgaon');
            SqlCommand command = new SqlCommand("Insert into employee values("+empID+",'"+name+"','"+email+"','"+ph+"','"+city+"')", connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return "Employee Succefully added";
        }
    }
}
