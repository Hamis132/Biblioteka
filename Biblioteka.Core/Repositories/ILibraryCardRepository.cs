using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Biblioteka.Core.Domain;

namespace Biblioteka.Core.Repositories
{
    public interface ILibraryCardRepository
    {
         Task<LibraryCard> GetAsync(int number);
         Task<LibraryCard> GetAsync(Guid userId);
         Task<IEnumerable<LibraryCard>> GetAllAsync();
         Task AddAsync(LibraryCard libraryCard);
         Task UpdateAsync(LibraryCard libraryCard);
         Task RemoveAsync(int number);
    }
}