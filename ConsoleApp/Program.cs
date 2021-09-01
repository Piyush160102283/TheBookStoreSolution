using DataAccessLayer;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BookStoreRepository repository = new BookStoreRepository();
            var books = repository.GetAllBooks();
            foreach (var book in books) {
                Console.WriteLine(book.Title);
            }
        }
    }
}
