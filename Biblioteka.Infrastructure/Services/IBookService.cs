using System;
using System.Threading.Tasks;
using Biblioteka.Core.Domain;
using Biblioteka.Infrastructure.DTO;

namespace Biblioteka.Infrastructure.Services
{
    public interface IBookService
    {
         Task AddBookAsync(string name, Author author, string genre, DateTime relasedAt);
         Task<BookDto> GetAsync(string name);
    }
}