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
        public static string sqlrequest = "Data Source=DESKTOP-00LQG0A;Initial Catalog=bankDB;Integrated Security=True";
        public string AddEmploye()
        {
            Console.Write("Enter ID\t:");
            int empID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name\t:");
            string name = Console.ReadLine();
            Console.Write("Enter email\t:");
            string email = Console.ReadLine();
            Console.Write("Enter Phone Number\t:");
            string ph = Console.ReadLine();
            Console.Write("Enter City\t:");
            string city = Console.ReadLine();
            SqlConnection connection = new SqlConnection(sqlrequest);
            //insert into employee values(1,'yogesh','yoge@123','1234567899','jalgaon');
            SqlCommand command = new SqlCommand("Insert into employee values(" + empID + ",'" + name + "','" + email + "','" + ph + "','" + city + "')", connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return "Employee Succefully added";
        }
        public void SelectAllEmployee()
        {
            SqlConnection connection = new SqlConnection(sqlrequest);
            SqlCommand command = new SqlCommand("select * from employee", connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(read);
            connection.Close();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    Console.Write(table.Rows[i][j]+"\t");
                }
                Console.WriteLine();
            }
        }  
        public void SelectEmployeeByID()
        {
            Console.Write("Enter ID You want to display info\t:");
            int empID = Convert.ToInt32(Console.ReadLine());
            SqlConnection connection = new SqlConnection(sqlrequest);
            SqlCommand command = new SqlCommand("select * from employee where empID ="+empID+"", connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(read);
            connection.Close();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    Console.Write(table.Rows[i][j]+"\t");
                }
                Console.WriteLine();
            }
        }

        public string DeleteEmployee()
        {
            Console.Write("Enter ID You want to delete\t:");
            int empID = Convert.ToInt32(Console.ReadLine());
            SqlConnection connection = new SqlConnection(sqlrequest);
            SqlCommand command = new SqlCommand("Delete from employee where empID ="+empID+"", connection);
            connection.Open();
            int res = command.ExecuteNonQuery();
            connection.Close();
            if (res == 0)
                return "Not Deleted";
            return "Deleted";
        }
        public string UpdateEmail()
        {
            Console.WriteLine("Enter the id  which want to update the Email\t: ");
            int empID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Email \t: ");
            string email = Console.ReadLine();
            Console.WriteLine();
            SqlConnection connection = new SqlConnection(Emplyoee.sqlrequest);
            SqlCommand command = new SqlCommand("update employee set email = '" + email + "' where empID=" + empID + "", connection);
            connection.Open();
            int count = command.ExecuteNonQuery();
            connection.Close();
            if (count == 0)
                return "Not Updated";
            return "updated";
        }
    }
}