using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccessLayer
{
    public class BookStoreRepository
    {
        BOOKSTOREContext context;
        public BookStoreRepository() {
            context = new BOOKSTOREContext();
        }

        public List<Books> GetAllBooks() {

            var BookList = (from Books in context.Books
                            orderby Books.BookId
                            select Books).ToList();
            return BookList;
        }
    }
}
