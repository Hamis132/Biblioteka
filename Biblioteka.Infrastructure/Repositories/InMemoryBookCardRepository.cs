using System;
using System.Collections.Generic;
using Biblioteka.Core.Domain;
using Biblioteka.Core.Repositories;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka.Infrastructure.Repositories
{
    public class InMemoryBookCardRepository : IBookCardRepository
    {
        private static ISet<BookCard> _bookCards = new HashSet<BookCard>();
        public async Task AddAsync(BookCard bookCard)
        {
           await Task.FromResult(_bookCards.Add(bookCard));
        }
        public async Task<BookCard> GetAsync(int number)
            => await Task.FromResult(_bookCards.SingleOrDefault(x => x.Number == number));

        public async Task<BookCard> GetAsync(Guid bookId)
            => await Task.FromResult(_bookCards.SingleOrDefault(x => x.BookId == bookId));

        public async Task<IEnumerable<BookCard>> GetAllAsync()
            => await Task.FromResult(_bookCards);

        public async Task RemoveAsync(int number)
        {
            var bookCard = await GetAsync(number);
            _bookCards.Remove(bookCard);
        }
    }
}