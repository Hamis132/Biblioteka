using System;
using System.Collections.Generic;

namespace Biblioteka.Core.Domain
{
    public class BookCard
    {
        public Guid BookId {get; protected set;}
        public int Number {get; protected set;}
        public IEnumerable<Hire> Hires {get; protected set;}
        public DateTime CreatedAt {get; protected set;} 
        protected BookCard()
        {
        }
        public BookCard(Guid bookId,int number)
        {
            BookId = bookId;
            Number = number;
            CreatedAt = DateTime.UtcNow.Date;
        } 
    }
}