using System;

namespace Biblioteka.Core.Domain
{
    public class Book
    {
        public Guid Id {get; protected set;}
        public int BookCardNumber {get; protected set;}
        public string Name {get; protected set;}
        public Author Author {get; protected set;}
        public string Genre {get; protected set;}
        public DateTime RelasedAt {get; protected set;}
        protected Book()
        {
        }
        public Book(string name, Author author, string genre, DateTime relasedAt)
        {
            Id = Guid.NewGuid();
            Name = name;
            Author = author;
            Genre = genre;      //Gatunek literacki
            RelasedAt = relasedAt;
        }
        
    }
}