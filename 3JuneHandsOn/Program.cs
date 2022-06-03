using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3JuneHandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            ConstantAndReadonly constantAndReadonly = new ConstantAndReadonly(12);

            NestedClass.oClass oClass = new NestedClass.oClass();
            oClass.m1();
            NestedClass.oClass.iClass iClass= new NestedClass.oClass.iClass();
            iClass.m2();
            JaggedArray jagged = new JaggedArray();
            jagged.createAndPrintArray();

            MethodHiding methodHiding = new MethodHiding();
            methodHiding.method();

            NullableTypes nullableTypes = new NullableTypes();
            nullableTypes.method();

            Tuples tuples = new Tuples();
            tuples.printTuple();

            CheckAndUncheck checkAndUncheck = new CheckAndUncheck();
            checkAndUncheck.check("yogesh");
            checkAndUncheck.Uncheck("Ram");

            Console.Read();

        }
    }
}
