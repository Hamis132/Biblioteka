using System;
using System.Collections.Generic;

namespace Biblioteka.Core.Domain
{
    public class LibraryCard
    {
        public Guid UserId {get; protected set;}
        public int Number {get; protected set;}
        public IEnumerable<Hire> Hires {get; protected set;}
        public DateTime CreatedAt {get; protected set;}
        protected  LibraryCard()
        {
        }
        public LibraryCard(Guid userId,int number)
        {
            UserId = userId;
            Number = number;
            CreatedAt = DateTime.UtcNow.Date;
        }

    }
}