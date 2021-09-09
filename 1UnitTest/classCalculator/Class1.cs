using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Class1
    {

    }

    public class CalculatorChecker
    {
        public static bool validateOperation(double num1, double num2, string operation, double result)
        {
            if (operation == "+")
            {
                return (num1 + num2 == result);
            }

            if (operation == "-")
            {
                return (num1 - num2 == result);
            }

            if (operation == "*")
            {
                return (num1 * num2 == result);
            }

            if (operation == "/")
            {
                return (num1 / num2 == result);
            }



            return true;
        }
    }
}
