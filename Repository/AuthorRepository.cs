using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class AuthorRepository : RepositoryBase<Author>, IAuthorRepository
    {
        public AuthorRepository(RepositoryContext repositoryContext) 
            : base(repositoryContext) 
        { 
        }

        public IEnumerable<Author> GetAllAuthors(bool trackChanges) => 
            FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();

        public Author GetAuthor(Guid Id, bool trackChanges) => 
            FindByCondition(c => c.Id.Equals(Id), trackChanges)
            .SingleOrDefault();

        public IEnumerable<Author> GetAuthorByIds(IEnumerable<Guid> ids, bool trackChanges) =>
            FindByCondition(c => ids.Contains<Guid>(c.Id), trackChanges)
            .ToList();

        public void CreateAuthor(Author author) => Create(author);

        public void DeleteAuthor(Author author) => Delete(author);
    }
}
