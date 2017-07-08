using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Biblioteka.Core.Domain;

namespace Biblioteka.Core.Repositories
{
    public interface IBookRepository
    {
         Task<Book> GetAsync(Guid id);
         Task<Book> GetAsync(string name);
         Task<IEnumerable<Book>> GetAllAsync();
         Task AddAsync(Book book);
         Task RemoveAsync(Guid id);
    }
}