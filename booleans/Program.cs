using System;

namespace Booleans
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                string input;
                bool isMale, isTall;

                Console.Write("Enter if you are male (y/n): ");
                input = Convert.ToString(Console.ReadLine());
                if (input == "y")
                {
                    isMale = true;
                } else 
                {
                    isMale = false;
                }

                Console.Write("Enter if you are tall (y/n): ");
                input = Console.ReadLine();
                if (input == "y")
                {
                    isTall = true;
                } else 
                {
                    isTall = false;
                }

                if (isMale && isTall) 
                {
                    Console.WriteLine("You are male and tall."); 
                } else if (!isMale && !isTall) 
                {
                    Console.WriteLine("You are not male and not tall."); 
                } else if (isMale && !isTall)
                {
                    Console.WriteLine("You are male and not tall.");
                } else if (!isMale && isTall)
                {
                    Console.WriteLine("You are not male and tall.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
            
        }
    }
}
