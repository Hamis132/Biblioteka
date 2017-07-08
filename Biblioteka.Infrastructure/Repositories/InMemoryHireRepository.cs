using System;
using System.Collections.Generic;
using Biblioteka.Core.Domain;
using Biblioteka.Core.Repositories;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka.Infrastructure.Repositories
{
    public class InMemoryHireRepository : IHireRepository
    {
        private static ISet<Hire> _hires = new HashSet<Hire>();
        public async Task AddAsync(Hire hire)
        {
           await Task.FromResult(_hires.Add(hire));
        }

        public async Task<Hire> GetAsync(Guid id)
            => await Task.FromResult(_hires.SingleOrDefault(x => x.Id == id));

        public async Task<IEnumerable<Hire>> GetAllAsync()
            => await Task.FromResult(_hires);

        public async Task RemoveAsync(Guid id)
        {
            var hire = await GetAsync(id);
            _hires.Remove(hire);
        }

        public async Task UpdateAsync(Hire hire)
        {
            await Task.CompletedTask;
            throw new NotImplementedException(); //Jeszcze nie wiem
        }
    }
}