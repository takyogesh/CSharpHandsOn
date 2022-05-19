using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BillingAndInventoryManagementSystem
{
    public class UserModule
    {

        int userid;
        string fname;
        string lname;
        string email;
        string phone;
        FileStream fileStreamobj;
        StreamWriter streamWriterObj;
        public UserModule()
        {
            FileStream fileStreamobj = new FileStream(@"C:\CustomFiles\User.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamobj);
            streamWriterObj.WriteLine("User Details");
            streamWriterObj.WriteLine("UserID\tFName\tLName\tEmail\t\tPhoneNo");
            streamWriterObj.Close();
            fileStreamobj.Close();
        }
        public void  UserDetails()
        {
            Console.WriteLine("Enter Customer Detail");
            Console.WriteLine("Enter ID");
            this.userid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter First Name");
            this.fname = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            this.lname = Console.ReadLine();
            Console.WriteLine("Enter Email");
            this.email = Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            this.phone = Console.ReadLine();
        }
        public void Write()
        {
            fileStreamobj = new FileStream(@"C:\CustomFiles\User.txt", FileMode.Append, FileAccess.Write);
            streamWriterObj = new StreamWriter(fileStreamobj);
            streamWriterObj.WriteLine(userid+"\t"+fname+"\t"+lname+"\t"+email+"\t"+phone);
            Console.WriteLine("writing done");
            streamWriterObj.Close();
            fileStreamobj.Close();
        }
        public void Read()
        {
            fileStreamobj = new FileStream(@"C:\CustomFiles\User.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStreamobj);
            streamReaderObj.ReadLine();
            while (streamReaderObj.Peek() > 0)
            {
                string line = streamReaderObj.ReadLine(); 
                string[] data = line.Split('\t');   //split on the basis of space(\t)
                foreach(String user in data)
                {
                    Console.Write(user + "\t");
                }
                Console.WriteLine();
            }
            fileStreamobj.Close();
            streamReaderObj.Close();
        }


    }
}
