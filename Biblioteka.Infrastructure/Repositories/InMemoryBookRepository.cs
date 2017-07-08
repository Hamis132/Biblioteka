using System;
using System.Collections.Generic;
using Biblioteka.Core.Domain;
using Biblioteka.Core.Repositories;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka.Infrastructure.Repositories
{
    public class InMemoryBookRepository : IBookRepository
    {
        private static ISet<Book> _books = new HashSet<Book>();
        public async Task<Book> GetAsync(Guid id)
            => await Task.FromResult(_books.Single(x => x.Id == id));

        public async Task<Book> GetAsync(string name)
            => await Task.FromResult(_books.Single(x => x.Name == name));

        public async Task<IEnumerable<Book>> GetAllAsync()
            => await Task.FromResult(_books);
        public async Task AddAsync(Book book)
        {
           await Task.FromResult(_books.Add(book));
        }
        public async Task RemoveAsync(Guid id)
        {
            var book = await GetAsync(id);
            _books.Remove(book);
        }
    }
}