using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookService
{
    interface IBookService
    {
        IEnumerable<Book> AllBooks();
        IEnumerable<Author> AllAuthors();
        IEnumerable<Book> BooksByAuthor(string name);
        IEnumerable<Book> BooksByYear(int year);
        IEnumerable<Book> BooksBetweenYears(int yearA, int yearB);
        IEnumerable<Book> BooksBetweenRating(double ratingA, double ratingB);
        IEnumerable<Book> LeastFavouriteBooks(double rating);
        IEnumerable<Book> MostFavouriteBooks(double rating);
        IEnumerable<Book> FilterBooksBy(Func<Book, bool> expression);

        IEnumerable<Book> BooksByAuthor(IEnumerable<Book> books, string name);
        IEnumerable<Book> BooksByYear(IEnumerable<Book> books, int year);
        IEnumerable<Book> BooksBetweenYears(IEnumerable<Book> books, int yearA, int yearB);
        IEnumerable<Book> BooksBetweenRating(IEnumerable<Book> books, double ratingA, double ratingB);
        IEnumerable<Book> FilterBooksBy(IEnumerable<Book> books, Func<Book, bool> expression);
    }
}
