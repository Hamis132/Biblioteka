using System;
using System.Collections.Generic;

namespace Biblioteka.Infrastructure.DTO
{
    public class AuthorDto
    {
        public Guid Id {get; set;}
        public string Name {get; set;}
        public string Surname {get; set;}
        public IEnumerable<BookDto> Books {get; set;}

    }
}