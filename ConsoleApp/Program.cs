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

            Console.WriteLine("---------------------------------------------------------");
            //For- GetBookById() method
            int id = 1;
            var b = repository.GetBookById(id);
            Console.WriteLine(b.Title);
        }
    }
}
