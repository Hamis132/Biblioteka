using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Biblioteka.Core.Domain;

namespace Biblioteka.Core.Repositories
{
    public interface IBookCardRepository
    {
         Task<BookCard> GetAsync(int number);
         Task<BookCard> GetAsync(Guid bookId);
         Task<IEnumerable<BookCard>> GetAllAsync();
         Task AddAsync(BookCard bookCard);
         Task RemoveAsync(int number);
    }
}