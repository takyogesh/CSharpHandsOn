using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeAndDeserialize
{
    class Program
    {
        static void Main(string[] args)
        {
            EbBill e = new EbBill();
            e.add();
            e.JSONDeserialize();
            e.JSONDeserialize();
            e.XMLSerialize();
            e.XMLDeSerialize();
            Console.Read();
        }
    }
}
