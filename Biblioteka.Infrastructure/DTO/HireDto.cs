using System;

namespace Biblioteka.Infrastructure.DTO
{
    public class HireDto
    {
        public Guid Id {get; set;}
        public int BookCardNumber {get; set;}
        public int LibraryCardNumber {get; set;}
        public DateTime BorrowedAt {get; set;}
        public DateTime ReturnedAt {get; set;}
    }
}