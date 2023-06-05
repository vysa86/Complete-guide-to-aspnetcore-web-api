using My_Books.Data.Models;
using My_Books.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Books.Data.Service
{
    public class PublisherService
    {
       private AppDbContext context { get; set; }
        public PublisherService(AppDbContext context)
        {
            this.context = context;
        }
        public void AddPublisher(PublisherVM publisher)
        {
            var _publisher = new Publisher()
            {
                Name = publisher.FullName

            };
            context.Publishers.Add(_publisher);
            context.SaveChanges();
        }
    }

}
