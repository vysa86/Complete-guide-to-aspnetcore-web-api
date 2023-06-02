using My_Books.Data.Models;
using My_Books.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Books.Data
{
    public class BookService
    {
      private AppDbContext  context{ get; set; }
        public BookService(AppDbContext context)
        {
            this.context = context;
        }
        public void AddBook(BookVM book)
        {
            var _book=new Book()
            {
                 Title=book.Title,
                 Description=book.Description,
                 IsRead=book.IsRead,
                 DateRead= book.IsRead?book.DateRead:null,
                 Rate=book.IsRead?book.Rate.Value:null,
                 Genere=book.Genere,
                 Author=book.Author,
                 CoverUrl=book.CoverUrl,
                 DateAdded=DateTime.Now

            };
            context.Books.Add(_book);
            context.SaveChanges();
        }

        public List<Book> GetAllBooks() => context.Books.ToList();

        public Book GetBookById(int bookId) => context.Books.FirstOrDefault(n => n.Id ==bookId);

        public Book UpdateBookById(int id,BookVM book)
        {

            var _book = context.Books.FirstOrDefault(n => n.Id == id);
            if (_book != null)
            {
                _book.Title = book.Title;
                _book.Description = book.Description;
                _book.IsRead = book.IsRead;
                _book.DateRead = book.IsRead ? book.DateRead : null;
                _book.Rate = book.IsRead ? book.Rate.Value : null;
                _book.Genere = book.Genere;
                _book.Author = book.Author;
                _book.CoverUrl = book.CoverUrl;
                context.SaveChanges();
            }
            return _book;
          
        }
        public void DeleteBookById(int bookId) { 
           var _book= context.Books.FirstOrDefault(n => n.Id == bookId);
            if (_book!=null)
            {
                context.Books.Remove(_book);
                context.SaveChanges();
            }
        }
    }
}
