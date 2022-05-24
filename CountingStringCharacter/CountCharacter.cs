using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace CountingStringCharacter
{
    class CountCharacter
    {

        public String read()
        {
            FileStream fs = new FileStream(@"C:\CustomFiles\CharCount.txt", FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            String s = sr.ReadLine();
            fs.Close();
            sr.Close();
            return s;
        }
        public void count(String s)
        {
            char[] ch = s.ToCharArray();

         
            List<char> charList = new List<char>();
            List<char> charList1 = new List<char>();

            foreach (char c in ch)
                charList.Add(c);
           
            for (int i=0; i<charList.Count; i++)
            {
                   if(!charList1.Contains(charList[i]))
                        charList1.Add(charList[i]);
            }

            Dictionary<char, int> d = new Dictionary<char, int>();

            int count = 0;
            for(int i=0; i<charList1.Count;i++)
            {
                for(int j=0;j<charList.Count;j++)
                {
                    if (charList1[i] == charList[j])
                        count++;
                }
                d.Add(charList1[i],count);
                count = 0;

            }
            foreach(var di in d)
            {
                Console.WriteLine(di.Key+": "+di.Value);
            }
          
        }
    }
}
