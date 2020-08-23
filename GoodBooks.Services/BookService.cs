using System;
using System.Collections.Generic;
using GoodBooks.Data;
using GoodBooks.Data.Models;
using System.Linq;

namespace GoodBooks.Services
{
    public class BookService : IBooksService
    {
        private readonly GoodBooksDbContext dbContext;
        public BookService(GoodBooksDbContext db){
            dbContext = db;
        }
        public void AddBook(Book book)
        {
            dbContext.Add(book);
            dbContext.SaveChanges();
        }

        public void DeleteBook(int bookId)
        {
            var bookToDelete = dbContext.Books.Find(bookId);
            if(bookToDelete != null)
            {
                dbContext.Remove(bookToDelete);
            }
            throw new InvalidOperationException("Book doesnt exists!"); 
        }

        public List<Book> GetAllBooks()
        {
            return dbContext.Books.ToList();
        }

        public Book GetBook(int bookId)
        {
            return dbContext.Books.Find(bookId);
        }
    }
}
