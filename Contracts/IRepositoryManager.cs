using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager 
    { 
        ITextRepository Text { get; } 
        IAuthorRepository Author { get; } 
        IPhotoRepository Photo { get; }
        Task SaveAsync();
    }
}
