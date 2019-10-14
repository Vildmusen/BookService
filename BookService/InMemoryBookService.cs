using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookService
{
    class InMemoryBookService : IBookService
    {
        private List<Book> books;
        private List<Author> authors;

        public InMemoryBookService()
        {
            books = new List<Book>();
            authors = new List<Author>();

            Book book1 = new Book("8092102014001241", "Bok1", 1998, 4.5, 123);
            Book book2 = new Book("8092102014001242", "Bok2", 1998, 3.5, 13);
            Book book3 = new Book("8092102014001243", "Bok3", 2001, 2.5, 1203);
            Book book4 = new Book("8092102014001244", "Bok4", 2004, 4.7, 21);
            Book book5 = new Book("8092102014001245", "Bok5", 1995, 4.1, 54);

            Author author1 = new Author("Harald Jättebra");
            Author author2 = new Author("Anna Lingonpaj");

            ConnectBookAndAuthor(book1, author1);
            ConnectBookAndAuthor(book2, author1);
            ConnectBookAndAuthor(book2, author2);
            ConnectBookAndAuthor(book3, author2);
            ConnectBookAndAuthor(book4, author1);
            ConnectBookAndAuthor(book4, author2);
            ConnectBookAndAuthor(book5, author1);
            
            books.Add(book1);
            books.Add(book2);
            books.Add(book3);
            books.Add(book4);
            books.Add(book5);

            authors.Add(author1);
            authors.Add(author2);
        }

        public void ConnectBookAndAuthor(Book book, Author author)
        {
            book.Authors.Add(author);
            author.Books.Add(book);
        }

        public IEnumerable<Book> AllBooks()
        {
            return books;
        }

        public IEnumerable<Author> AllAuthors()
        {
            return authors;
        }

        public IEnumerable<Book> BooksByAuthor(string name)
        {
            return authors.Where(x => x.Name == name).Select(y => y.Books).FirstOrDefault();
        }

        public IEnumerable<Book> BooksByYear(int year)
        {
            return books.Where(x => x.YearOfPublication == year);
        }

        public IEnumerable<Book> BooksBetweenYears(int yearA, int yearB)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> LeastFavouriteBooks(int count)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> MostFavouriteBooks(int count)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> FilterBooksBy(Func<Book, bool> expression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> LeastFavouriteBooks(double rating)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> MostFavouriteBooks(double rating)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> BooksBetweenRating(double ratingA, double ratingB)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> BooksByAuthor(IEnumerable<Book> books, string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> BooksByYear(IEnumerable<Book> books, int year)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> BooksBetweenYears(IEnumerable<Book> books, int yearA, int yearB)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> BooksBetweenRating(IEnumerable<Book> books, double ratingA, double ratingB)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> FilterBooksBy(IEnumerable<Book> books, Func<Book, bool> expression)
        {
            throw new NotImplementedException();
        }
    }
}
