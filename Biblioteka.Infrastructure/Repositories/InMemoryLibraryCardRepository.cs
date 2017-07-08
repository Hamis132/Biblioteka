using System;
using System.Collections.Generic;
using Biblioteka.Core.Domain;
using Biblioteka.Core.Repositories;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka.Infrastructure.Repositories
{
    public class InMemoryLibraryCardRepository : ILibraryCardRepository
    {
        private static ISet<LibraryCard> _libraryCards = new HashSet<LibraryCard>();
        public async Task AddAsync(LibraryCard libraryCard)
        {
           await Task.FromResult(_libraryCards.Add(libraryCard));
           await Task.CompletedTask;
        }

        public async Task<LibraryCard> GetAsync(int number)
            => await Task.FromResult(_libraryCards.SingleOrDefault(x => x.Number == number));

        public async Task<LibraryCard> GetAsync(Guid userId)
            => await Task.FromResult(_libraryCards.SingleOrDefault(x => x.UserId == userId));
        public async Task<IEnumerable<LibraryCard>> GetAllAsync()
            => await Task.FromResult(_libraryCards);

        public async Task RemoveAsync(int number)
        {
            var libraryCard = await GetAsync(number);
            _libraryCards.Remove(libraryCard);
            await Task.CompletedTask;
        }

        public async Task UpdateAsync(LibraryCard libraryCard)
        {
            await Task.CompletedTask; //Jeszcze nie wiem
        }
    }
}