using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingAndInventoryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //User details
            UserModule userModuleObj = new UserModule();
            userModuleObj.UserDetails();        //Insert the details
            userModuleObj.Write();                 //write intxt file
            userModuleObj.Read();                  // read from txt file

            Console.WriteLine("*****************");
            // catergory details
            CategoryModule categoryModuleObj = new CategoryModule();
            categoryModuleObj.CategoryDetails();
            categoryModuleObj.Write();

            Console.WriteLine("*****************");
            //Product Details
            ProductModule productModuleObj = new ProductModule();
            productModuleObj.ProductDetails();
            productModuleObj.Write();

            Console.WriteLine("*****************");
            //Purchase and sell details
            PurchaseAndSellModule purchaseAndSellModuleObj = new PurchaseAndSellModule();
            purchaseAndSellModuleObj.PurchaseDetails();
            purchaseAndSellModuleObj.Write();


            Console.Read();
        }
    }
}
