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

        static  int count = 12;
        int index=0;
        String[] myData= new String[count];
        public void Read()
        {
            FileStream fileStreamObj = new FileStream(@"C:\CustomFiles\NetworkLogs.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStreamObj);
            Console.WriteLine("Id\tSource\t\tDestination\tDate\t\tTime\t\tStatus\t\tNetwork");
           
            while (streamReaderObj.Peek() > 0)
            {
               
                string line = streamReaderObj.ReadLine();
                if (line != "")
                {
                    if (!line.StartsWith("Date"))
                    {
                        string[] data = line.Split(':');
                        if (myData[index] == null)
                        {
                            myData[index] = data[1]+"\t";
                        }
                        else
                            myData[index] = myData[index] + " " + data[1] + "  \t";
                    }
                    else
                    {
                        string[] dateTime = line.Split(' ');
                        string[] date = dateTime[0].Split(':');
                        myData[index] = myData[index] + date[1] + "\t" + dateTime[1] + " " + dateTime[2] + "\t";
                    }
                }
                else
                    index++;
            }

            fileStreamObj.Close();
            streamReaderObj.Close();

        }
        public void printMyData()
        {
            foreach (String s in myData)
                Console.WriteLine(s);
        }
        public void success()
        {
            foreach (String s in myData)
            {
                if(s.Contains("Success"))
                     Console.WriteLine(s);
            }
        } public void missed()
        {
            foreach (String s in myData)
            {
                if(s.Contains("Missed"))
                     Console.WriteLine(s);
            }
        } public void failed()
        {
            foreach (String s in myData)
            {
                if(s.Contains("Failed"))
                     Console.WriteLine(s);
            }
        } public void dialled()
        {
            foreach (String s in myData)
            {
                if(s.Contains("Dialled"))
                     Console.WriteLine(s);
            }
        }
    }
    
}
