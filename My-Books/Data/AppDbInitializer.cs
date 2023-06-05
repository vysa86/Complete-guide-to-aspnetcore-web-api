using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using My_Books.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Books.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applocationBuilder)
        {
            using(var serviceScope = applocationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Title = "1st Book Title",
                        Description = "1st Book Description",
                        IsRead = true,
                        Genere="Comedy",
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Author = "First Author",
                        CoverUrl = "Https...",
                        DateAdded = DateTime.Now

                    },
                    new Book()
                    {
                        Title = "2ND Book Title",
                        Description = "2ND Book Description",
                        IsRead = false,
                       Genere="Biography",
                        Rate = 4,
                        Author = "2ND Author",
                        CoverUrl = "Https...",
                        DateAdded = DateTime.Now

                    });

                   // context.SaveChanges();

                }
            }
        }
    }
}
