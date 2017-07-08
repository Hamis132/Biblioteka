using System;
using Biblioteka.Infrastructure.DTO;

namespace Biblioteka.Infrastructure.Services
{
    public interface ILibraryCardService
    {
         void CreateLibraryCard(int number);
         LibraryCardDto Get(Guid id);
    }
}