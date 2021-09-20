using System;
using System.Collections.Generic;
//using System.Ling;
using System.Text;
using System.Threading.Tasks;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello " + name + ". You are " + age + ".");
            
        }
    }
}
