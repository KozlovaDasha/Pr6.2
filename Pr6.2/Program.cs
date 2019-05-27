using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr6
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library(5);
            library.books[0] = new Book("J.K. Rowling", "Harry Potter", 2035, 1997, 522, "Fantasy");
            library.books[1] = new Book(" Margaret Brown", "Goodnight Moon", 1042, 1851, 746, "Novel");
            library.books[2] = new Book("Margret Rey", "Curious George", 4234, 1605, 1023, "Novel");
            library.books[3] = new Book("Leo Tostoy", "Anna Karenina", 9431, 1898, 1402, "Tragedy");
            library.books[4] = new Book("Shel Silverstein", "The Giving Tree", 1234, 1930, 416, "Fairytail");

            foreach (var book in library.books)
            {
                Console.WriteLine(book.ToString());
            }

            library.CompareTwoBooks();
            library.SearchByCode();

            Console.ReadLine();
        }
    }
}
