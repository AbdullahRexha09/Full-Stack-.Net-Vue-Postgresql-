using Microsoft.EntityFrameworkCore;
using GoodBooks.Data.Models;
using System;

namespace GoodBooks.Data
{
    public class GoodBooksDbContext : DbContext
    {
        public GoodBooksDbContext(){

        }
        public GoodBooksDbContext(DbContextOptions options):base(options){

        }
        public virtual DbSet<Book> Books {get;set;}
        public virtual DbSet<BooksReview> BooksReviews {get;set;}

        
    }
}