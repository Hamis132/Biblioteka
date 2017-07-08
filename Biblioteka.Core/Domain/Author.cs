using System;
using System.Collections.Generic;

namespace Biblioteka.Core.Domain
{
    public class Author
    {
        public Guid Id {get; protected set;}
        public string Name {get; protected set;}
        public string Surname {get; protected set;}
        public IEnumerable<Book> Books {get; protected set;}
        protected Author()
        {
        }
        public Author(string name,string surname)
        {
            Id = Guid.NewGuid();
            Name = name;
            Surname = surname;
        }
    }
}