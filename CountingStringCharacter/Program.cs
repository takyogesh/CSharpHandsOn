using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingStringCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            CountCharacter cs = new CountCharacter();
            // count the char of string from console i.e take input from user
            Console.WriteLine("----------------------------Enter the String");
            cs.count(Console.ReadLine());

            Console.WriteLine("----------------------------by reading txt file");
            //by reading string from txt file 
             string s=  cs.read();
            cs.count(s);
            Console.WriteLine("----------------------------by passing string");
            //by passing the input 
            cs.count("Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Nunc accumsan sem ut ligula scelerisque sollicitudin." +
                " Ut at sagittis augue. Praesent quis rhoncus justo. " +
                "Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. " +
                "Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. " +
                "Donec nec velit non ligula efficitur luctus.");


            Console.Read();
        }
    }
}
