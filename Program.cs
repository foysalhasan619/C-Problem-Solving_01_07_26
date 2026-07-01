using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powersoft_EaxamDay2_Ans1
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine ($"\nAddition : {Add(num1, num2)}");
            Console.WriteLine($"Subtraction : {Subtract(num1, num2)}");
            Console.WriteLine($"Multiplication : {Multiply(num1, num2)}");

            if (num2 != 0)
            {
                Console.WriteLine($"Division : {Divide(num1, num2)}");
            }
            else
            {
                Console.WriteLine("Division : Cannot divide by zero.");
            }

        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}