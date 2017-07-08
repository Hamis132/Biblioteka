using System;
using Biblioteka.Infrastructure.DTO;

namespace Biblioteka.Infrastructure.Services
{
    public interface IBookCardService
    {
         void CreateBookCard(Guid bookId, int number);
         BookCardDto Get(int number);
    }
}