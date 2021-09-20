using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int num;
            Console.Write("Enter your name please: ");
            name = Console.ReadLine();
            SayHi(name);
            Console.Write("Enter a integer to be cubed: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(cube(num));
            Console.ReadLine();
        }

        static void SayHi(string name) 
        {
            Console.WriteLine("Hello " + name + "!");
        }

        static int cube(int num) 
        {
            int result = num * num * num;
            return result;
        }

    }
}
