using System;
using static System.Console;

namespace Assignment8ex2
{
    public class MathSolutions
    {
        delegate double mathProduct(double x, double y);
        public double GetSum(double x, double y)
        {
            return x + y;
        }
        public double GetProduct(double a, double b)
        {
            return a * b;
        }
        public void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }
        static void Main(string[] args)
        {

            MathSolutions answer = new MathSolutions();
            Func<double, double, double> mathSum = answer.GetSum;
            Action<double, double> mathCompare = answer.GetSmaller;
            mathProduct mathProduct = answer.GetProduct;
            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);
            Console.WriteLine($" {num1} + {num2} = {mathSum(num1,num2)}");
            Console.WriteLine($" {num1} x {num2} = {mathProduct(num1, num2)}");
            mathCompare(num1, num2);
        }
    }
}