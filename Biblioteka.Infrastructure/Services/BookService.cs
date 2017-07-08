using System;
using System.Threading.Tasks;
using Biblioteka.Core.Domain;
using Biblioteka.Core.Repositories;
using Biblioteka.Infrastructure.DTO;

namespace Biblioteka.Infrastructure.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task AddBookAsync(string name, Author author, string genre, DateTime relasedAt)
        {
            var book = await _bookRepository.GetAsync(name);
            if(book != null)
            {
                throw new Exception($"Book with name '{name}' already exist.");
            }
            book = new Book(name,author,genre,relasedAt);
           await  _bookRepository.AddAsync(book);
        }

        public async Task<BookDto> GetAsync(string name)
        {
            await Task.CompletedTask;
            //comming soon!
            throw new NotImplementedException();
        }
    }
}