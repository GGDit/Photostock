using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Contracts;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;

        private ITextRepository _textRepository;
        private IAuthorRepository _authorRepository;
        private IPhotoRepository _photosRepository;

        public RepositoryManager(RepositoryContext repositoryContext) 
        { 
            _repositoryContext = repositoryContext; 
        }
        public IAuthorRepository Author
        { 
            get 
            { 
                if (_authorRepository == null)
                    _authorRepository = new AuthorRepository(_repositoryContext); 

                return _authorRepository; 
            } 
        }

        public ITextRepository Text
        {
            get
            {
                if (_textRepository == null)
                    _textRepository = new TextRepository(_repositoryContext);

                return _textRepository;
            }
        }

        public IPhotoRepository Photo
        {
            get
            {
                if (_photosRepository == null)
                    _photosRepository = new PhotoRepository(_repositoryContext);

                return _photosRepository;
            }
        }

        public Task SaveAsync() => _repositoryContext.SaveChangesAsync();
    }
}
