using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuCalc
{
   public interface CalcInterface
    {
         int add(int num1,int num2);
         int sub(int num1,int num2);
         int mul(int num1,int num2);
         double div(double num1,double num2);
    }
}
