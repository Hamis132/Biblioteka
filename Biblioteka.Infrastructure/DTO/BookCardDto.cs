using System;
using System.Collections.Generic;

namespace Biblioteka.Infrastructure.DTO
{
    public class BookCardDto
    {
        public Guid BookId {get; set;}
        public int Number {get; set;}
        public IEnumerable<HireDto> Hires {get; set;}
        public DateTime CreatedAt {get; set;} 
    }
}