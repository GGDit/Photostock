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
    public class TextRepository : RepositoryBase<Text>, ITextRepository
    {
        public TextRepository(RepositoryContext repositoryContext) 
            : base(repositoryContext) 
        { 
        }

        public async Task<IEnumerable<Text>> GetAllTextsAsync(bool trackChanges) => 
            await FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToListAsync();
        public async Task<Text> GetTextAsync(Guid Id, bool trackChanges) =>
            await FindByCondition(c => c.Id.Equals(Id), trackChanges)
            .SingleOrDefaultAsync();
        public async Task<IEnumerable<Text>> GetTextByIdsAsync(IEnumerable<Guid> ids, bool trackChanges) =>
            await FindByCondition(x => ids.Contains(x.Id), trackChanges)
            .ToListAsync();

        public IEnumerable<Text> GetAllAuthors(bool trackChanges) => 
            FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();

        public Text GetText(Guid Id, bool trackChanges) => 
            FindByCondition(c => c.Id.Equals(Id), trackChanges)
            .SingleOrDefault();

        public IEnumerable<Text> GetTextByIds(IEnumerable<Guid> ids, bool trackChanges) =>
            FindByCondition(c => ids.Contains<Guid>(c.Id), trackChanges)
            .ToList();

        public void CreateText(Text text) => Create(text);

        public void DeleteText(Text text) => Delete(text);
    }
}
