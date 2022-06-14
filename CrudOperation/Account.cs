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
        public string AddAccount()
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
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "Not Added";
            }
            finally
            {
                connection.Close();
            }
            return "Account Succefully added";
        }
        public string UpdateCity()
        {
            Console.WriteLine("Enter the id  which want to update the city\t: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the city name \t: ");
            string city = Console.ReadLine();
            Console.WriteLine();
            SqlConnection connection = new SqlConnection(Emplyoee.sqlrequest);
            SqlCommand command = new SqlCommand("update account set city = '"+city+"' where ID="+id+"",connection);
            connection.Open();
           int count= command.ExecuteNonQuery();
            connection.Close();
            if (count != 0)
                return "Not Updated";
            return "updated";
        }
        public void SelectAllAccount()
        {
            SqlConnection connection = new SqlConnection(Emplyoee.sqlrequest);
            SqlCommand command = new SqlCommand("select * from account",connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            connection.Close();
            DataTable table = new DataTable();
            table.Load(read);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    Console.Write(table.Rows[i][j]+"\t");
                }
                Console.WriteLine();
            }

        } 
        public void SelectAccountByID()
        {
            Console.WriteLine("Enter the id  which you want to view record\t: ");
            int id = Convert.ToInt32(Console.ReadLine());

            SqlConnection connection = new SqlConnection(Emplyoee.sqlrequest);
            SqlCommand command = new SqlCommand("select * from account where ID ="+id+"",connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            connection.Close();
            DataTable table = new DataTable();
            table.Load(read);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    Console.Write(table.Rows[i][j]+"\t");
                }
                Console.WriteLine();
            }

        }
        public string DeletedAccount()
        {

            Console.WriteLine("Enter the id  which want to Delete the Account\t: ");
            int id = Convert.ToInt32(Console.ReadLine());
          
            SqlConnection connection = new SqlConnection(Emplyoee.sqlrequest);
            SqlCommand command = new SqlCommand("Delete from account where ID=" + id + "", connection);
            connection.Open();
            int count = command.ExecuteNonQuery();
            connection.Close();
            if (count != 0)
                    return "Deleted";
            return "Not Deleted";
        }
    }
}
