using System;

namespace Biblioteka.Core.Domain
{
    public class Hire
    {
        public Guid Id {get; protected set;}
        public int BookCardNumber {get; protected set;}
        public int LibraryCardNumber {get; protected set;}
        public DateTime BorrowedAt {get; protected set;}
        public DateTime ReturnedAt {get; protected set;}
        protected Hire()
        {
        }
        protected Hire(int bookCardNumber, int libraryCardNumber, DateTime borrowedAt)
        {
            Id = Guid.NewGuid();
            BookCardNumber = bookCardNumber;
            LibraryCardNumber = libraryCardNumber;
            BorrowedAt = borrowedAt;
        }

        public static Hire Create(int bookCardNumber, int libraryCardNumber, DateTime borrowedAt)
            => new Hire(bookCardNumber,libraryCardNumber,borrowedAt);
    }
}