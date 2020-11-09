using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStrore.Models.Repositores
{
    public class BookRepository : IBookStroreRepository<Book>
    {
        List<Book> books;
        public BookRepository()
        {
            books = new List<Book>()
            {
                new Book
                {
                    Id=1, Title = "C# Programming" , Description="no Description"
                },
                new Book
                {
                   Id=2, Title = "Php Programming" , Description="no Description",

                },
                new Book
                {
                   Id=3, Title = "Node Programming" , Description="no Description",
                 }
            };
        }
        public void Add(Book entity)
        {
            books.Add(entity);
        }

        public void Delete(int id)
        {
            var book = Find(id);
            books.Remove(book);
        }

        public Book Find(int id)
        {
            var book = books.SingleOrDefault(x=>x.Id==id);
            return book;
        }

        public IList<Book> List()
        {
            return books;
        }

        public void Update(Book newBook , int id)
        {
            var book = Find(id);
            book.Title = newBook.Title;
            book.Author = newBook.Author;
            book.Description = newBook.Description;

        }
    }
}
