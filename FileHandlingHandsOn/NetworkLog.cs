using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingHandsOn
{
    class NetworkLog
    {
        public void Read()
        {
            FileStream fileStreamObj = new FileStream(@"C:\CustomFiles\NetworkLogs.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStreamObj);
            Console.WriteLine("Id\tSource\t\tDestination\tDate\t\tTime\t\tStatus\tNetwork");
           
            while (streamReaderObj.Peek() > 0)
            {
                string line = streamReaderObj.ReadLine();
                if (line != "")
                {
                    if (!line.StartsWith("Date"))
                    {
                        string[] data = line.Split(':');
                        Console.Write(data[1] + "\t");
                    }
                    else
                    {
                        string[] dateTime = line.Split(' ');
                        string[] date=dateTime[0].Split(':');
                        Console.Write(date[1]+"\t"+dateTime[1]+" "+dateTime[2]+"\t");
                    }
                }
                else
                    Console.WriteLine();
            }
            fileStreamObj.Close();
            streamReaderObj.Close();

        }
    }
}
