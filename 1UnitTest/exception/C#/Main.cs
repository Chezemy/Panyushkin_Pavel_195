using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            try
            {
                Console.WriteLine("Enter first number: ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter second number: ");
                b = Convert.ToDouble(Console.ReadLine());

                if (b == 0)
                    Console.WriteLine("you cannot divide by zero ");
                else
                    Console.WriteLine("Result:" + " " + a / b);

            }
            catch
            {
                Console.WriteLine("Invalid input");
            }
                Console.WriteLine("Size of integer in bytes:" + " " + sizeof(int));
                Console.WriteLine("Size of float in bytes:" + " " + sizeof(float));
            }
        }

}