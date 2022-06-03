using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3JuneHandsOn
{
    class JaggedArray
    {
        public JaggedArray()
        {
            Console.WriteLine("***************Jagged Array*****************");
        }

        public void createAndPrintArray()
        {
            int col = 3;
            int[][] ticketCounter = new int[col][];
            ticketCounter[0]= new int []{24,21,18,23 };
            ticketCounter[1]= new int []{43,52,49,33,39,41};
            ticketCounter[2]= new int []{65,71 };

            for(int i=0;i<ticketCounter.Length;i++)
            {
                for(int j=0; j<ticketCounter[i].Length;j++)
                {
                    Console.Write("passenger :" + ticketCounter[i][j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
