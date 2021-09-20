using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
            }

	        Console.ReadLine();

            int index = 1;
            while (index <= 20) 
            {
                Console.WriteLine(index);
                index++;
            }

            Console.ReadLine();
        }
    }
}
