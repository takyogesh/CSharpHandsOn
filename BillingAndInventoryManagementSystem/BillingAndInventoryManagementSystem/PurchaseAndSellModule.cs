using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BillingAndInventoryManagementSystem
{
    class PurchaseAndSellModule:ProductModule
    {
        int salesId;
        int productid;
        int price;
        string salesdate;
        FileStream fileStreamobj;
        StreamWriter streamWriterObj;
        public PurchaseAndSellModule()
        {
            FileStream fileStreamobj = new FileStream(@"C:\CustomFiles\Purchase.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamobj);
            streamWriterObj.WriteLine("Purchase Details");
            streamWriterObj.WriteLine("SalesId\tProductid\t\tprice\tsalesdate");
            streamWriterObj.Close();
            fileStreamobj.Close();
        }
        public void PurchaseDetails()
        {
            Console.WriteLine("Enter Purchase Detail");
            Console.WriteLine("Enter Sales ID");
            this.salesId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product ID");
            this.productid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Price");
            this.price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Date");
            this.salesdate = Console.ReadLine();
            Write();
        }
        private void Write()
        {
            fileStreamobj = new FileStream(@"C:\CustomFiles\Purchase.txt", FileMode.Append, FileAccess.Write);
            streamWriterObj = new StreamWriter(fileStreamobj);
            streamWriterObj.WriteLine(salesId + "\t" + productid + "\t" + price + "\t" + salesdate );
            Console.WriteLine("writing done");
            streamWriterObj.Close();
            fileStreamobj.Close();
        }
        public override void Read()
        {
            fileStreamobj = new FileStream(@"C:\CustomFiles\Purchase.txt", FileMode.Open, FileAccess.Read);
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
