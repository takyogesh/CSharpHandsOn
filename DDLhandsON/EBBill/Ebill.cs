using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EBBill
{
    public class Ebill
    {
       public int customerID { get; set; }
        public string customerName { get; set; }
        public int noOfUnits { get; set; }
        public int unitsPerCost { get; set; } = 10;
        public int total { get; set; }

        List<Ebill> ebill = new List<Ebill>();

        private Ebill(int customerID, string customerName, int noOfUnits)
        {
            this.customerID = customerID;
            this.customerName = customerName;
            this.noOfUnits = noOfUnits;
            tBill();
        }public Ebill() { }

        public void CustomerData(int iD,String name,int units)
        {
            Ebill bill = new Ebill(iD, name, units);
            ebill.Add(bill);
        }
        private void tBill()
        {
            total = unitsPerCost * noOfUnits;
        }
        public void ShowCustomerDetails(int customerID)
        {
            foreach(var data in ebill)
            {
                if (data.customerID == customerID)
                    Console.WriteLine("CustomerID :" + data.customerID + "\tCustomerName :" + data.customerName + "\tUsage in Units :" + data.noOfUnits);
            }
        }
        public void ShowEbBill(int customerID)
        {
            foreach (var data in ebill)
            {
                if (data.customerID == customerID)
                    Console.WriteLine("CustomerID :" + data.customerID + "\tCustomerName :" + data.customerName + "\tUsage in Units :" + data.noOfUnits+ "\tTotalBill :"+ data.total);
            }
        }
        public void ShowEbBillReport()
        {
            foreach (var data in ebill)
            {
                    Console.WriteLine("CustomerID :" + data.customerID + "\tCustomerName :" + data.customerName + "\tUsage in Units :" + data.noOfUnits + "\tTotalBill :" + data.total);
            }

        }

    }
}
