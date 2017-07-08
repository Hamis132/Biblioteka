using System;
using Biblioteka.Core.Domain;

namespace Biblioteka.Infrastructure.DTO
{
    public class BookDto
    {
        public Guid Id {get; set;}
        public string Name {get; set;}
        public AuthorDto Author {get; set;}
        public string Genre {get; set;}
        public DateTime RelasedAt {get; set;}
    }
}