using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace LinqHandsOn
{
    class LinqProgram
    {
        public void one()
        {
            Console.WriteLine("progrom number 1----------------------");

            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var result = from list in n
                         where list > 0
                         select list;

            var result1 = (from list in n
                           where list > 0
                           select list).ToArray();

            Console.WriteLine("All positive numbers are");
           /* foreach (var num in result)
            {
                Console.Write(num + " ");
            }*/
            Console.WriteLine();
            for (int i = 0; i < result1.Length; i++)
            {
                Console.Write(result1[i] + " ");
            }
            Console.WriteLine();
        }
        public void two()
        {
            Console.WriteLine("progrom number 2----------------------");

            int[] arr = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var res = from list in arr
                      group list by list into list2
                      select list2;

            foreach (var num in res)
            {
                Console.WriteLine("Number " + num.Key + " appears " + num.Count() + " times");
            }
        } 
        public void three()
        {
            Console.WriteLine("progrom number 3----------------------");

            string s = "apple";

            var result = from chArr in s group chArr by chArr into chArr1  select chArr1;

            foreach (var str in result)
            {
                Console.WriteLine("Character " + str.Key + " : " + str.Count() + " times");
            }
        }
        public void four()
        {
            Console.WriteLine("progrom number 4----------------------");

            string[] arr = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var res = from lis in arr
                      where (lis.StartsWith("A") && lis.EndsWith("M"))
                      select lis;
            foreach (var result in res)
            {
                Console.WriteLine("The city starting with A and ending with M is : " + result);
            }
        }
        public void five()
        {
            Console.WriteLine("progrom number 5----------------------");

            int[] arr = { 5, 7, 13, 24, 6, 9, 8, 7 };

            var res = (from lis in arr
                       orderby lis descending
                       select lis).Take(3);
            foreach (var result in res)
            {
                Console.WriteLine(result);
            }
        }
        public void six()
        {
            Console.WriteLine("progrom number 6----------------------");

            List<Students> stulist = new List<Students>();
            stulist.Add(new Students { StuId = 1, StuName = " Joseph ", GrPoint = 800 });
            stulist.Add(new Students { StuId = 2, StuName = "Alex", GrPoint = 458 });
            stulist.Add(new Students { StuId = 3, StuName = "Harris", GrPoint = 900 });
            stulist.Add(new Students { StuId = 4, StuName = "Taylor", GrPoint = 900 });
            stulist.Add(new Students { StuId = 5, StuName = "Smith", GrPoint = 458 });
            stulist.Add(new Students { StuId = 6, StuName = "Natasa", GrPoint = 700 });
            stulist.Add(new Students { StuId = 7, StuName = "David", GrPoint = 750 });
            stulist.Add(new Students { StuId = 8, StuName = "Harry", GrPoint = 700 });
            stulist.Add(new Students { StuId = 9, StuName = "Nicolash", GrPoint = 597 });
            stulist.Add(new Students { StuId = 10, StuName = "Jenny", GrPoint = 750 });

            var res = (from lis in stulist
                       group lis by lis.GrPoint into newlis
                       orderby newlis.Key descending
                       select newlis).ToList();
            //we want to find the 3rd rank holder from student list
            //so i=2, if we wamt 1st rank holder then i=0
            int i = 2;

            foreach (var stu in stulist)
            {
                if (res[2].Key == stu.GrPoint)
                {
                    Console.WriteLine(" Id : " + stu.StuId + ",  Name : " + stu.StuName + ",  achieved Grade Point : " + stu.GrPoint);
                }
            }
        }
        public void SevenEightNine()
        {
            List<Person> people = new List<Person>()
            {
            new Person("Bill", "Smith", 41),
            new Person("Sarah", "Jones", 22),
            new Person("Stacy","Baker", 21),
            new Person("Vivianne","Dexter", 19 ),
            new Person("Bob","Smith", 49 ),
            new Person("Brett","Baker", 51 ),
            new Person("Mark","Parker", 19),
            new Person("Alice","Thompson", 18),
            new Person("Evelyn","Thompson", 58 ),
            new Person("Mort","Martin", 58),
            new Person("Eugene","DeLauter", 84 ),
            new Person("Gail","Dawson", 19 )
            };

            var result = people.Where(x => x.lName[0] == 'D');

            var res = from lis in people
                      where lis.lName.StartsWith("D")
                      select lis;
            Console.WriteLine("progrom number 7----------------------");
            foreach (var resu in result)
            {
               Console.WriteLine(resu.ToString());
            }
            /*foreach(var resu in res)
            {
				Console.WriteLine(resu.lName);
            }*/

            Console.WriteLine("progrom number 8----------------------");
            Console.WriteLine("number of people who's 1st name start with D : "+res.Count());

            Console.WriteLine("progrom number 9----------------------");
            var older = from lis in people
                        where lis.age > 40
                        select lis;
            foreach (var res1 in older)
            {
                Console.Write(res1.fName + " ");
            }
            Console.WriteLine();
        }
        public void ten()
        {
            Console.WriteLine("progrom number 10----------------------");

            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };
            var res = from f in fruits
                      where f.StartsWith("L")
                      select f;
            foreach (var result in res)
            {
                Console.WriteLine(result);
            }
        }
        public void eleven()
        {
            Console.WriteLine("progrom number 11----------------------");

            List<int> mixedNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var res = from lis in mixedNumbers
                      where (lis % 4 == 0 || lis % 6 == 0)
                      select lis;
            foreach (var result in res)
            {
                Console.Write(result + " ");
            }
        }
    }
    public class Students
    {
        public int StuId ;
        public string StuName ;
        public int GrPoint ;
    }
    public class Person
    {
       public string fName;
       public string lName;
       public int age;
        public Person(string fName, string lName, int age)
        {
            this.fName = fName;
            this.lName = lName;
            this.age = age;
        }
        public override string ToString()
        {
            return lName;
        }
    }
}
