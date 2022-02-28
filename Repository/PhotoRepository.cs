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
    public class PhotoRepository : RepositoryBase<Photo>, IPhotoRepository
    {
        public PhotoRepository(RepositoryContext repositoryContext) 
            : base(repositoryContext) 
        { 
        }

        public async Task<IEnumerable<Photo>> GetAllPhotosAsync(bool trackChanges) => 
            await FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToListAsync();
        public async Task<Photo> GetPhotoAsync(Guid Id, bool trackChanges) =>
            await FindByCondition(c => c.Id.Equals(Id), trackChanges)
            .SingleOrDefaultAsync();
        public async Task<IEnumerable<Photo>> GetPhotoByIdsAsync(IEnumerable<Guid> ids, bool trackChanges) =>
            await FindByCondition(x => ids.Contains(x.Id), trackChanges)
            .ToListAsync();

        public IEnumerable<Photo> GetAllAuthors(bool trackChanges) => 
            FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();

        public Photo GetPhoto(Guid Id, bool trackChanges) => 
            FindByCondition(c => c.Id.Equals(Id), trackChanges)
            .SingleOrDefault();

        public IEnumerable<Photo> GetPhotoByIds(IEnumerable<Guid> ids, bool trackChanges) =>
            FindByCondition(c => ids.Contains<Guid>(c.Id), trackChanges)
            .ToList();

        public void CreatePhoto(Photo photo) => Create(photo);

        public void DeletePhoto(Photo photo) => Delete(photo);
    }
}
