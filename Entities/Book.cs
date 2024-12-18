namespace LibraryManagementSystem.Entities
{
    public partial class Book : IEquatable<Book>
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string ISBN { get; private set; }
        public string Publisher { get; private set; }
        public int YearPublished { get; private set; }
        public string Genre { get; private set; }
        public bool IsBorrowed { get; private set; }

        private Book(BookBuilder builder)
        {
            Title = builder.Title;
            Author = builder.Author;
            ISBN = builder.ISBN;
            Publisher = builder.Publisher;
            YearPublished = builder.YearPublished;
            Genre = builder.Genre;
            IsBorrowed = false;
        }

        public void Borrow()
        {
            if (IsBorrowed == true)
                throw new InvalidOperationException("This book is currently unavailable");
            IsBorrowed = true;
        }

        public void ReturnBook()
        {
            if (IsBorrowed == false)
                return;
            IsBorrowed = false;
        }

        public bool Equals(Book? book){
            if(book is null){
                return false;
            }

            return Title == book.Title &&
                    Author == book.Author &&
                    ISBN == book.ISBN &&
                    Publisher == book.Publisher &&
                    YearPublished == book.YearPublished &&
                    Genre == book.Genre &&
                    IsBorrowed == book.IsBorrowed;
        }
    }
}