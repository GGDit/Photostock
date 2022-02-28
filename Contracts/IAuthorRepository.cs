using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.Models;

namespace Contracts
{
    public interface IAuthorRepository
    {
        IEnumerable<Author> GetAllAuthors(bool trackChanges); 
        IEnumerable<Author> GetAuthorByIds(IEnumerable<Guid> ids, bool trackChanges);
        Author GetAuthor(Guid Id, bool trackChanges);
        void CreateAuthor(Author author);
        void DeleteAuthor(Author author);
    }
}
