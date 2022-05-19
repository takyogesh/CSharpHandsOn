using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BillingAndInventoryManagementSystem
{
    class ProductModule
    {
        int productid;
        string categorytype;
        string productname;
        int quantity;
        int price;
        FileStream fileStreamobj;
        StreamWriter swObj;
        public ProductModule()
        {
            FileStream fileStreamobj = new FileStream(@"C:\CustomFiles\Product.txt", FileMode.Create, FileAccess.Write);
            StreamWriter swObj = new StreamWriter(fileStreamobj);
            swObj.WriteLine("Product Details");
            swObj.WriteLine("Productid\tCategoryType\tproductname\tquantity\tprice");
            swObj.Close();
            fileStreamobj.Close();
        }
        public void ProductDetails()
        {
            Console.WriteLine("Enter Product Detail");
            Console.WriteLine("Enter Product ID");
            this.productid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Category Type");
            this.categorytype = Console.ReadLine();
            Console.WriteLine("Enter Product Name");
            this.productname = Console.ReadLine();
            Console.WriteLine("Enter quantity");
            this.quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Price");
            this.price = Convert.ToInt32(Console.ReadLine());
            Write();
        }
        public virtual void Write()
        {
            fileStreamobj = new FileStream(@"C:\CustomFiles\Product.txt", FileMode.Append, FileAccess.Write);
            swObj = new StreamWriter(fileStreamobj);
            swObj.WriteLine(productid + "\t" + categorytype + "\t" + productname + "\t" + quantity+ "\t" + price);
            Console.WriteLine("writing done");
            swObj.Close();
            fileStreamobj.Close();
        }
        public virtual void Read()
        {
            fileStreamobj = new FileStream(@"C:\CustomFiles\Product.txt", FileMode.Open, FileAccess.Read);
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
