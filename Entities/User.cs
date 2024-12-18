using System.Collections.Generic;

namespace LibraryManagementSystem.Entities
{
    public class User : IEquatable<User>
    {
        public string Name { get; private set; }
        public List<Book> BorrowedBooks { get; private set; } = new List<Book>();

        public User(string name)
        {
            Name = name;
        }

        public void BorrowBook(Book book)
        {
            book.Borrow();
            BorrowedBooks.Add(book);
        }

        public void ReturnBook(Book book)
        {
            book.ReturnBook();
            BorrowedBooks.Remove(book);
        }

        public bool Equals(User? user)
        {
            if (user is null)
            {
                return false;
            }

            return Name == user.Name && BorrowedBooks.SequenceEqual(user.BorrowedBooks);
        }
    }
}