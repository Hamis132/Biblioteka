using System;
using Biblioteka.Core.Domain;
using Biblioteka.Infrastructure.DTO;

namespace Biblioteka.Infrastructure.Services
{
    public interface IAuthorService
    {
         void AddAuthor(string name, string surname);
         void AddBookToAuthor(Book book);
         AuthorDto Get(Guid id);
    }
}