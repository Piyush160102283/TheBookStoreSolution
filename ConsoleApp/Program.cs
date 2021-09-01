using DataAccessLayer;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BookStoreRepository repository = new BookStoreRepository();

            //For- GetAllBooks() method
            var books = repository.GetAllBooks();
            foreach (var book in books) {
                Console.WriteLine(book.Title);
            }

            //For- GetAllBooks() method
            int id = 1;
            var b = repository.GetBook();
            foreach (var book in b)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
