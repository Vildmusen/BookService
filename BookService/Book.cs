using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookService
{
    class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public int YearOfPublication { get; set; }
        public double Rating { get; set; }
        public int NumberOfUserVotes { get; set; }
        public ICollection<Author> Authors { get; set; }

        public Book() { }

        public Book(string isbn, string title, int year, double rating, int userVotes)
        {
            ISBN = isbn;
            Title = title;
            YearOfPublication = year;
            Rating = rating;
            NumberOfUserVotes = userVotes;
            Authors = new List<Author>();
        }

        public override string ToString()
        {
            string output = String.Format("{0}", Title);
            foreach (Author a in Authors)
            {
                output += String.Format(", {0}", a.ToString());
            }
            return output;
        }
    }
}
