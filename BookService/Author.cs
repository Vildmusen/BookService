using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookService
{
    class Author
    {
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }

        public Author() { }

        public Author(string name)
        {
            Name = name;
            Books = new List<Book>();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
