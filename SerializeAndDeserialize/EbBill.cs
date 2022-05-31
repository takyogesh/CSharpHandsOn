using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Newtonsoft.Json;
using System.IO;
using System.Xml.Serialization;
namespace SerializeAndDeserialize
{
   public class EbBill
    {

        public int customerID { get; set; }
        public string customerName { get;set; }
        public int noOfUnits { get; set; }
        public int unitsPerCost { get; set; } = 7;
        public int total { get; set; }
        public List<EbBill> customer=new List<EbBill>();

        public override string ToString()
        {
            return "customerID :\t"+customerID+"\tcustomerName :\t"+ customerName+ "\tnoOfUnits :\t"+ noOfUnits+ "\ttotalBill :\t"+ total;
        }
        public EbBill(int customerID, string customerName, int noOfUnits)
        {
            this.customerID = customerID;
            this.customerName = customerName;
            this.noOfUnits = noOfUnits;
            tBill();
        }
        public EbBill() { }
        private void tBill()
        {
            total = unitsPerCost * noOfUnits;
        }
        public void add()
        {
            Console.WriteLine("how many customer you want to add");
            int i = 0;
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1 to add customer \n Enter 2 to exit ");
            int caseswitch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Customer id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customer name");
            string name = Console.ReadLine();
            Console.WriteLine("enter the units");
            int units = Convert.ToInt32(Console.ReadLine());
            while (i < num)
            {
                switch (caseswitch)
                {
                    case 1:
                        {
                            addCutomer(new EbBill(id, name, units));
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Exit");
                            break;
                        }
                }
                i++;
            }
        }
        public void addCutomer(EbBill e)
        {
            customer.Add(e);
        }
        public void print()
        {
            foreach (var data in customer)
            {
                Console.WriteLine(data.ToString());
            }
        }
        public void XMLSerialize()
        {
            FileStream fs = new FileStream(@"C:\CustomFiles\SerializeXMLfile.txt", FileMode.Create);
            XmlSerializer xmlObj = new XmlSerializer(typeof(List<EbBill>));
            xmlObj.Serialize(fs, customer);
            fs.Close();
        }
        public void JSONSerialize()
        {
            JsonSerializer js = new JsonSerializer();
            StreamWriter sw = new StreamWriter(@"C:\CustomFiles\SerializeJSONfile.txt");
            JsonTextWriter jst = new JsonTextWriter(sw);
            js.Serialize(jst, customer);
            sw.Close();
            jst.Close();
        }
        public void JSONDeserialize()
        {
            FileStream fs = new FileStream(@"C:\CustomFiles\SerializeJSONfile.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            String s = sr.ReadLine();
            List<EbBill> de = JsonConvert.DeserializeObject<List<EbBill>>(s);
            foreach (var data in de)
            {
                Console.WriteLine(data);
            }
            fs.Close();
            sr.Close();
        }
        public void XMLDeSerialize()
        {
            FileStream fs = new FileStream(@"C:\CustomFiles\SerializeXMLfile.txt", FileMode.Open);
            XmlSerializer xs = new XmlSerializer(typeof(List<EbBill>));
            List<EbBill> customer = (List<EbBill>)xs.Deserialize(fs);
           foreach(var data in customer)
           {
                Console.WriteLine(data);
           }
            fs.Close();
        }
        }
}
