using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class ListGradeBook
    {
        List<string> students = new List<string>();
        List<double> grades = new List<double>();
        String name;
        double grade;
        public void gradebook()
        {
            Console.WriteLine("Enter your students (or ENTER to finish):");

            // Get student names
            do
            {
               String name = Console.ReadLine();
             

                if (!Equals(name, ""))
                {
                    students.Add(name);
                }

            } while (!Equals(name, ""));

            foreach(var s in students)
            {
                Console.WriteLine(s);
            }

          
        }
        public void Stugrade()
        {
            foreach (string student in students)
            {
                Console.WriteLine("Grade for " + student + ": ");
                grade = Convert.ToDouble( Console.ReadLine());
                double grade = double.Parse(input);
                grades.Add(grade);
            }

            // Print class roster
            Console.WriteLine("\nClass roster:");
            double sum = 0.0;

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i] + " (" + grades[i] + ")");
                sum += grades[i];
            }

            double avg = sum / students.Count;
            Console.WriteLine("Average grade: " + avg);
        }
    }
}
