using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStrore.Models.Repositores
{
    public class AuthorRepository : IBookStroreRepository<Author>
    {
        IList<Author> authors;
        public AuthorRepository()
        {
            authors = new List<Author>()
           {
               new Author
               {Id = 1 , FullName = "Ali Sayed" },
               new Author   {Id=2,FullName="Ahmed Mohamed"},
               new Author {Id=3,FullName="Sayed Galal"}
           };
        }
        public void Add(Author entity)
        {
            authors.Add(entity);
        }

        public void Delete(int id)
        {
            var author = Find(id);
            authors.Remove(author);
        }

        public Author Find(int id)
        {
            var author = authors.SingleOrDefault(a => a.Id == id);
            return author;
        }

        public IList<Author> List()
        {
            return authors;
        }

        public void Update(Author newAuthor, int id)
        {
            var author = Find(id);
            author.FullName = newAuthor.FullName;
        }
    }
}
