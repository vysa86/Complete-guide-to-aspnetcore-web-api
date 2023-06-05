using My_Books.Data.Models;
using My_Books.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Books.Data.Service
{
    public class AuthorService
    {
        private AppDbContext context { get; set; }
        public AuthorService(AppDbContext context)
        {
            this.context = context;
        }
        public void AddAuthor(AuthorVM author)
        {
            var _author = new Author()
            {
                FullName = author.FullName

            };
            context.Authors.Add(_author);
            context.SaveChanges();
        }

    }
}
