using System;
using Biblioteka.Infrastructure.DTO;

namespace Biblioteka.Infrastructure.Services
{
    public interface IHireService
    {
         void HireTheBook(int libraryCardNumber, int BookCardNumber);

         HireDto Get(Guid id);
    }
}