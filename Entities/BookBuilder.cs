namespace LibraryManagementSystem.Entities;

public partial class Book
{
    public class BookBuilder
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string ISBN { get; private set; }
        public string Publisher { get; private set; }
        public int YearPublished { get; private set; }
        public string Genre { get; private set; }

        public BookBuilder(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public BookBuilder WithISBN(string isbn){
            ISBN = isbn;
            return this;
        }

        public BookBuilder WithPublisher(string publisher){
            Publisher = publisher;
            return this;
        }

        public BookBuilder WithYearPublished(int yearPublished){
            YearPublished = yearPublished;
            return this;
        }

        public BookBuilder WithGenre(string genre){
            Genre = genre;
            return this;
        }

        public Book Build(){
            return new Book(this);
        }
    }
}