using System;
using classesBook;

namespace classesLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("The Chronicles of Narnia: The Lion, the Witch and the Wardrobe", "C. S. Lewis", 1950, 224);
            Book book2 = new Book("The Hobbit, or There and Back Again", "J. R. R. Tolkien", 1937, 310);
            Console.WriteLine(book1.isOld().ToString());
            Console.ReadLine();
        }
    }
}
