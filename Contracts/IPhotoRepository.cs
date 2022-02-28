using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.Models;

namespace Contracts
{
    public interface IPhotoRepository
    {
        IEnumerable<Photo> GetAllPhotos(bool trackChanges); 
        IEnumerable<Photo> GetPhotoByIds(IEnumerable<Guid> ids, bool trackChanges);
        Photo GetPhoto(Guid Id, bool trackChanges);
        void CreatePhoto(Photo photo);
        void DeletePhoto(Photo photo);
    }
}
