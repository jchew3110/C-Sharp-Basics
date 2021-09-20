using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "The Chronicles of Narnia: The Lion, the Witch and the Wardrobe";
            book1.author = "C. S. Lewis";
            book1.pages = 224;

            Console.WriteLine(book1.title);
            Console.ReadLine();
        }
    }
}
