using LibraryManagementSystem.LibraryDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.LibraryDataAccess.Service
{
    public class BookService
    {
        public LibraryDBContext cxt;

        public BookService(LibraryDBContext cxt)
        {
            this.cxt = cxt;
        }

        public List<Book> GetBooks() => cxt.Books.ToList();

        public void AddBook(Book book) 
        {
        cxt.Books.Add(book);
        cxt.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            cxt.Books.Update(book);
            cxt.SaveChanges();
        }
        public void RemoveBook(int bookId) 
        {
            var book = cxt.Books.Find(bookId);
            cxt.Books.Remove(book);
            cxt.SaveChanges();
        
        }
    }
}
