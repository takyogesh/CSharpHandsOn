using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BillingAndInventoryManagementSystem
{
    class CategoryModule:ProductModule
    {
        int categoryid;
        string categorytype;
        FileStream fileStreamobj;
        StreamWriter streamWriterObj;
        public CategoryModule()
        {
            FileStream fileStreamobj = new FileStream(@"C:\CustomFiles\Category.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamobj);
            streamWriterObj.WriteLine("Category Details");
            streamWriterObj.WriteLine("Category Id\tCategoryType");
            streamWriterObj.Close();
            fileStreamobj.Close();
        }
        public void CategoryDetails()
        {
            Console.WriteLine("Enter Category Detail");
            Console.WriteLine("Enter Category ID");
            this.categoryid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Category Type");
            this.categorytype = Console.ReadLine();
        }
        public override void Write()
        {
            fileStreamobj = new FileStream(@"C:\CustomFiles\Category.txt", FileMode.Append, FileAccess.Write);
            streamWriterObj = new StreamWriter(fileStreamobj);
            streamWriterObj.WriteLine(Convert.ToString(categoryid) + "\t" + categorytype);
            Console.WriteLine("writing done");
            streamWriterObj.Close();
            fileStreamobj.Close();
        }
        public override void Read()
        {
            fileStreamobj = new FileStream(@"C:\CustomFiles\Category.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStreamobj);
            streamReaderObj.ReadLine();
            while (streamReaderObj.Peek() > 0)
            {
                string line = streamReaderObj.ReadLine();
                string[] data = line.Split('\t');   //split on the basis of space(\t)
                foreach (String user in data)
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
