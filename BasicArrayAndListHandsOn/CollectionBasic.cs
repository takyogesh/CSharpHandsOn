using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BasicArrayAndListHandsOn
{
    class CollectionBasic
    {
        public void basicImplementation()
        {
            int[] number = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("-------------Integer Array----------------");
            foreach(int n in number)
            {
                Console.Write(n+"\t");
            }
            String[] names = { "Tim", "Martin", "Nikki", "Sara" };
            Console.WriteLine("\n-----------------Name Array-------------");
            foreach (String s in names)
            {
                Console.Write(s + "\t");
            }

            String[] alterValue = new String[10];
            for (int i = 0; i < alterValue.Length; i++)
            {
                if (i % 2 == 0)
                    alterValue[i] = "true";
                else
                    alterValue[i] = "false";
            }
            Console.WriteLine("\n------------TrueFalse Altervalue Array------------");
            foreach (String s in alterValue)
            {
                Console.Write(s + "\t");
            }
            ArrayList listOfIcecream = new ArrayList();

            listOfIcecream.Add("Vanila");
            listOfIcecream.Add("Safron");
            listOfIcecream.Add("butterscotch");
            listOfIcecream.Add("chocolate");
            listOfIcecream.Add("fruitNut");
            listOfIcecream.Add("oreo");
            listOfIcecream.Add("mango");

            Console.WriteLine("\nIce Cream List\t:" + listOfIcecream.Count);
            Console.WriteLine("------------List of icre-cream flavour--------------");
            foreach (String s in listOfIcecream)
            {
                Console.WriteLine(s);
            }
            int get = 2;
            Console.WriteLine("3rd flavour in the list\t:" + listOfIcecream[get]);
            listOfIcecream.RemoveAt(2);
            Console.WriteLine("list of icecream flavour after removing 3rd flour\t:" + listOfIcecream.Count);

        }
    }
}
