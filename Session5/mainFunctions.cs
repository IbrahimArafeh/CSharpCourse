using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5
{
    internal class mainFunctions
    {
        NI_DBEntities _db;
        public mainFunctions()
        {
            _db = new NI_DBEntities();
        } 
        
        /// <summary>
        /// get all book from NI_DB as list 
        /// </summary>
        /// <returns></returns>
        public List<Book> getAllBooks()
        {
            List<Book> bookResultList = new List<Book>();
            
            bookResultList = _db.Books.ToList();

            return bookResultList;

        }

        /// <summary>
        /// add new book to DB
        /// </summary>
        /// <param name="book"></param>
        public void addBook(Book book)
        {
            _db.Books.Add(book);
            _db.SaveChanges();
        }

        public Book getBook(string word)
        {
            Book resultBook = _db.Books.Where(s => s.Title == word).FirstOrDefault();

            return resultBook;
        }

        public List<Book> getManyBook(string word)
        {
            List<Book> resultBook = _db.Books.Where(s => s.Title == word).ToList();

            return resultBook;
        }

    }
}
