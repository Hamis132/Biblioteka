using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Biblioteka.Core.Domain;

namespace Biblioteka.Core.Repositories
{
    public interface IAuthorRepository
    {
         Task<Author> GetAsync(Guid id);
         Task<Author> GetAsync(string name,string surname);
         Task<IEnumerable<Author>> GetAllAsync();
         Task AddAsync(Author author);
         Task UpdateAsync(Author author);
         Task RemoveAsync(Guid id);

    }
}