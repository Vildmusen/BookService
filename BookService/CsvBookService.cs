using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookService
{
    class CsvBookService : IBookService
    {
        CsvParser parser;
        List<Book> books;
        List<Author> authors;

        public CsvBookService()
        {
            parser = new CsvParser();
            books = new List<Book>();
            authors = new List<Author>();
            parser.ParseCsv();
            books.AddRange(parser.GetBooks());
            authors.AddRange(parser.GetAuthors());
        }

        public IEnumerable<Author> AllAuthors()
        {
            return authors;
        }

        public IEnumerable<Book> AllBooks()
        {
            return books;
        }

        public IEnumerable<Book> BooksBetweenYears(int yearA, int yearB)
        {
            return books.Where(x => x.YearOfPublication > yearA && x.YearOfPublication < yearB);
        }

        public IEnumerable<Book> BooksBetweenYears(IEnumerable<Book> books, int yearA, int yearB)
        {
            return books.Where(x => x.YearOfPublication > yearA && x.YearOfPublication < yearB);
        }

        public IEnumerable<Book> BooksByAuthor(string name)
        {
            return authors.Where(x => x.Name == name).Select(y => y.Books).FirstOrDefault();
        }

        public IEnumerable<Book> BooksByAuthor(IEnumerable<Book> books, string name)
        {
            return authors.Where(x => x.Name == name).Select(y => y.Books).FirstOrDefault();
        }

        public IEnumerable<Book> BooksByYear(int year)
        {
            return books.Where(x => x.YearOfPublication == year);
        }

        public IEnumerable<Book> BooksByYear(IEnumerable<Book> books, int year)
        {
            return books.Where(x => x.YearOfPublication == year);
        }

        public IEnumerable<Book> LeastFavouriteBooks(double rating)
        {
            return books.OrderBy(x => x.Rating < rating);
        }

        public IEnumerable<Book> MostFavouriteBooks(double rating)
        {
            return books.OrderByDescending(x => x.Rating > rating);
        }

        public IEnumerable<Book> BooksBetweenRating(double ratingA, double ratingB)
        {
            return books.Where(x => x.Rating > ratingA && x.Rating < ratingB);
        }

        public IEnumerable<Book> BooksBetweenRating(IEnumerable<Book> books, double ratingA, double ratingB)
        {
            return books.Where(x => x.Rating > ratingA && x.Rating < ratingB);
        }

        public IEnumerable<Book> FilterBooksBy(Func<Book, bool> expression)
        {
            return books.Where(expression);
        }

        public IEnumerable<Book> FilterBooksBy(IEnumerable<Book> books, Func<Book, bool> expression)
        {
            return books.Where(expression).Select(b =>b);
        }

        public Book BookByTitle(string title)
        {
            return books.Where(b => b.Title == title).FirstOrDefault();
        }
    }
}
