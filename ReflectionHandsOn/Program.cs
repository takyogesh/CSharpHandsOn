using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionHandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly executing = Assembly.GetExecutingAssembly();

            Type[] types = executing.GetTypes();
            foreach (var data in types)
            {
                Console.WriteLine("Class : {0}", data.Name);

                MethodInfo[] methods = data.GetMethods();
                foreach (var method in methods)
                {
                    Console.WriteLine("--> Method : {0}", method.Name);
                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (var arg in parameters)
                    {
                        Console.WriteLine("----> Parameter : {0} Type : {1}",
                                                arg.Name, arg.ParameterType);
                    }
                }
            }
            Console.Read();
        }


    }
}
