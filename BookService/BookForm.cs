using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BookService
{
    public partial class BookForm : Form
    {
        private IBookService service;

        public BookForm()
        {
            InitializeComponent();
            service = SimpleDI.GetService();
            AddProperties();
            Reset();
        }

        private void AddProperties()
        {
            property_combo_box.Items.Add("Number of Ratings");
            property_combo_box.Items.Add("Year of Publication");
            property_combo_box.Items.Add("Rating");
            property_combo_box.SelectedIndex = property_combo_box.FindString("Number of Ratings");
        }

        private void Reset()
        {
            UpdateBooksList(service.AllBooks());
            UpdateAuthorsList();
            author_name_input.Text = "";
            publication_year_input.Text = "";
            property_value_input.Text = "";
            between_years_low_input.Text = "";
            between_years_high_input.Text = "";
            rating_threshold_low_input.Text = "";
            rating_threshold_high_input.Text = "";
        }

        private void UpdateBooksList<T>(IEnumerable<T> source)
        {
            books_lstbox.Items.Clear();
            if (source == null) { return; }
            foreach (T item in source)
            {
                books_lstbox.Items.Add(item.ToString());
            }
        }

        private void UpdateAuthorsList()
        {
            authors_lstbox.Items.Clear();
            foreach (Author a in service.AllAuthors())
            {
                authors_lstbox.Items.Add(a.ToString());
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void filter_btn_Click(object sender, EventArgs e)
        {
            IEnumerable<Book> books = service.AllBooks(); // All books
            if (!String.IsNullOrEmpty(author_name_input.Text)) // If "Author" field is filled in
            {
                books = service.BooksByAuthor(books, author_name_input.Text);
            }
            if (!String.IsNullOrEmpty(publication_year_input.Text)) // If "Publication Year" field is filled in 
            {
                Int32.TryParse(publication_year_input.Text, out int year);
                books = service.BooksByYear(books, year);
            }
            if (!(String.IsNullOrEmpty(between_years_low_input.Text) && String.IsNullOrEmpty(between_years_high_input.Text))) // if both lower bound publication year and higher bound publication year is filled in.
            {
                Int32.TryParse(between_years_low_input.Text, out int yearLow);
                Int32.TryParse(between_years_high_input.Text, out int yearHigh);
                books = service.BooksBetweenYears(books, yearLow, yearHigh);
            }
            if (!(String.IsNullOrEmpty(rating_threshold_low_input.Text) && String.IsNullOrEmpty(rating_threshold_high_input.Text))) // if both lower bound rating and higher bound rating fields are filled in.
            {
                if(Double.TryParse(rating_threshold_low_input.Text, out double ratingLow) &&
                    Double.TryParse(rating_threshold_high_input.Text, out double ratingHigh))
                {
                    books = service.BooksBetweenRating(books, ratingLow, ratingHigh);
                }
            }
            if (!String.IsNullOrEmpty(property_value_input.Text))
            {
                switch (property_combo_box.SelectedItem.ToString())
                {
                    case "Rating":
                        books = handleRating(books);
                        break;
                    case "Year of Publication":
                        books = handlePublicationYear(books);
                        break;
                    default:
                        books = handleNumberOfRatings(books);
                        break;
                }
            }
            if(save_query_chk.Checked)
            {
                WriteToFile<Book>.WriteToTextFile(books);
            }
            UpdateBooksList(books);
        }

        private IEnumerable<Book> handleNumberOfRatings(IEnumerable<Book> books)
        {
            string input = property_value_input.Text;
            Func<Book, bool> expression;
            Int32.TryParse(input, out int ratings);
            if (lessthan_radio_btn.Checked)
            {
                expression = b => b.NumberOfUserVotes < ratings;
            }
            else if (greaterthan_radio_btn.Checked)
            {
                expression = b => b.NumberOfUserVotes > ratings;
            }
            else if (equals_radio_btn.Checked)
            {
                expression = b => b.NumberOfUserVotes == ratings;
            }
            else
            {
                expression = b => b.NumberOfUserVotes != ratings;
            }
            return service.FilterBooksBy(books, expression);
        }

        private IEnumerable<Book> handlePublicationYear(IEnumerable<Book> books)
        {
            string input = property_value_input.Text;
            Func<Book, bool> expression;
            Int32.TryParse(input, out int year);
            if (lessthan_radio_btn.Checked)
            {
                expression = b => b.YearOfPublication < year;
            }
            else if (greaterthan_radio_btn.Checked)
            {
                expression = b => b.YearOfPublication > year;
            }
            else if (equals_radio_btn.Checked)
            {
                expression = b => b.YearOfPublication == year;
            }
            else
            {
                expression = b => b.YearOfPublication != year;
            }
            return service.FilterBooksBy(books, expression);
        }

        private IEnumerable<Book> handleRating(IEnumerable<Book> books)
        {
            string input = property_value_input.Text;
            Func<Book, bool> expression;
            Double.TryParse(input, out double rating);
            if (lessthan_radio_btn.Checked)
            {
                expression = b => b.Rating < rating;
            }
            else if (greaterthan_radio_btn.Checked)
            {
                expression = b => b.Rating > rating;
            }
            else if (equals_radio_btn.Checked)
            {
                expression = b => b.Rating == rating;
            }
            else
            {
                expression = b => b.Rating != rating;
            }
            return service.FilterBooksBy(books, expression);
        }

        private void authors_lstbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = authors_lstbox.SelectedItem.ToString();
            author_name_input.Text = name;
            UpdateBooksList(service.BooksByAuthor(name));
        }

        private void publication_year_input_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(publication_year_input.Text))
            {
                between_years_high_input.ReadOnly = false;
                between_years_low_input.ReadOnly = false;
            } else
            {
                between_years_high_input.Text = "";
                between_years_high_input.ReadOnly = true;
                between_years_low_input.Text = "";
                between_years_low_input.ReadOnly = true;
            }
        }

        private void between_years_low_input_TextChanged(object sender, EventArgs e)
        {
            YearInputAvailability();
        }

        private void between_years_high_input_TextChanged(object sender, EventArgs e)
        {
            YearInputAvailability();
        }

        private void YearInputAvailability()
        {
            if (String.IsNullOrEmpty(between_years_low_input.Text) && String.IsNullOrEmpty(between_years_high_input.Text))
            {
                publication_year_input.ReadOnly = false;
            } else
            {
                publication_year_input.Text = "";
                publication_year_input.ReadOnly = true;
            }
        }
    }
}
