using System;
using System.Collections.Generic;
using Biblioteka.Core.Domain;
using Biblioteka.Core.Repositories;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka.Infrastructure.Repositories
{
    public class InMemoryAuthorRepository : IAuthorRepository
    {
        private static ISet<Author> _autors = new HashSet<Author>();
        public async Task AddAsync(Author author)
        {
            await Task.FromResult(_autors.Add(author));
        }

        public async Task<Author> GetAsync(Guid id)
            => await Task.FromResult(_autors.Single(x => x.Id == id));

        public async Task<Author> GetAsync(string name, string surname)
            => await Task.FromResult(_autors.Single(x=> x.Name == name && x.Surname == surname));
        public async Task<IEnumerable<Author>> GetAllAsync()
            =>await Task.FromResult(_autors);

        public async Task RemoveAsync(Guid id)
        {
            var author = await GetAsync(id);
            _autors.Remove(author);
        }

        public async Task UpdateAsync(Author author)
        {
            await Task.CompletedTask;
            throw new NotImplementedException();    //Jeszcze nie wiem 
        }
    }
}