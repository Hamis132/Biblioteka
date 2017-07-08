using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Biblioteka.Core.Domain;

namespace Biblioteka.Core.Repositories
{
    public interface IHireRepository
    {
        Task<Hire> GetAsync(Guid id);
         Task<IEnumerable<Hire>> GetAllAsync();
         Task AddAsync(Hire hire);
         Task UpdateAsync(Hire hire);
         Task RemoveAsync(Guid id);
    }
}