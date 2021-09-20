using System;

namespace classesBook
{
    public class Book
    {
        public string title;
        public string author;
        public int pages;
        public int date;

        public Book(string aTitle, string aAuthor, int aDate, int numPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = numPages;
            date = aDate;
            Console.WriteLine(author + " created " + title + " in " + date.ToString() + ". It has " + pages.ToString() + " pages.");
        }

        public string isOld() 
        {
            bool old;
            if (date >= 2000)
            {
                old = false;
            } else
            {
                old = true;
            }
            if (old == true)
            {
                return title + " is old.";
            } else
            {
                return title + " is not old.";
            }
        }

    }
}
