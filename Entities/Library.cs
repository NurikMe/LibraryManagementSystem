using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem.Entities
{
    public class Library
    {
        private static Library instance = null;
        private List<Book> books = new List<Book>();
        private List<User> users = new List<User>();

        private Library()
        {
        }

        public static Library Instance {
            get {
                if(instance is null){
                    instance = new Library();
                }

                return instance;
            }
        }

        public void AddBook(Book book)
        {
            if(books.Contains(book)){
                return;
            }
            books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public List<Book> FindBooksByTitle(string title)
        {
            return books.FindAll(book => book.Title == title);
        }

        public List<Book> FindBooksByAuthor(string author)
        {
            return books.FindAll(book => book.Author == author);
        }

        public void RegisterUser(User user)
        {
            if(!users.Contains(user)){
                users.Add(user);
            }
        }
    }
}