sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class CalculatorChecker
    {
        public static double ValidateCalculator(double sum1, double sum2, string operation)
        {
            if (operation == "+")
            {
                return (sum1 + sum2);
            }

            if (operation == "-")
            {
                return sum1 - sum2;

            }
            if (operation == "*")
            {
                return (sum1 * sum2);

            }
            if (operation == "/")
            {
                if (sum2 == 0.0D)
                {
                    throw new DivideByZeroException();


                }
                return (sum1 / sum2);
                try
                {


                    if (sum2 == 0)
                    {
                        Console.WriteLine("Вы не можете делить на ноль ");

                        return 1;
                    }
                    else
                        Console.WriteLine("Результат :" + " " + sum1 / sum2);

                }
                catch
                {
                    Console.WriteLine("Неправильный ввод");
                }


            }

            return 0;
        }
        static public void Main()
        {
            double a = 0;
            double b = 0;



            Console.WriteLine("Введите число 1");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            b = Convert.ToDouble(Console.ReadLine());
            double res = CalculatorChecker.ValidateCalculator(a, b, "*");
            Console.WriteLine("res" + res);
        }

    }
}
