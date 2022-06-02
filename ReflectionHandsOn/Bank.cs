using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionHandsOn
{
    class Bank
    {
        public int id{ get; set; }
        public string Name { get; set; }

        List<Bank>b=new List<Bank>();
        public Bank()
        {
            id = 0;
            Name = string.Empty;
        }
        public Bank(int rno, string n)
        {
            id = rno;
            Name = n;
        }
        public void displayData()
        {
            Console.WriteLine("ID : {0}", id);
            Console.WriteLine("Name : {0}", Name);
        }

    }
}
