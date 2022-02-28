using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.Models;

namespace Contracts
{
    public interface ITextRepository
    {
        IEnumerable<Text> GetAllTexts(bool trackChanges); 
        IEnumerable<Text> GetTextByIds(IEnumerable<Guid> ids, bool trackChanges);
        Text GetText(Guid Id, bool trackChanges);
        void CreateText(Text text);
        void DeleteText(Text text);
    }
}
