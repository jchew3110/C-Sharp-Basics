using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.Write("Enter a number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);
            Console.ReadLine();
        }
    }
}
