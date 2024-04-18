public class Library
{
    private IEnumerable<Book> _books;
    private IEnumerable<User> _users;

    private INotificationService _notification;


    public Library(INotificationService notification)
    {
        _books = [];
        _users = [];

        _notification = notification;
    }


    // Get all books
    public IEnumerable<Book> GetBooks()
    {
        return _books;
    }

    public IEnumerable<Book> GetBooks(int pageNumber, int recordsPerPage, SortOrder order)
    {
        var changedCollection = _books.Skip((pageNumber - 1) * recordsPerPage).Take(recordsPerPage);

        if (order == SortOrder.ASC)
        {
            return changedCollection.OrderBy(item => item.CreatedAt);
        }
        if (order == SortOrder.DESC)
        {
            return changedCollection.OrderByDescending(item => item.CreatedAt);
        }

        return _books;
    }

    public int GetBooksCount()
    {
        return _books.Count();
    }

    // Get all users
    public IEnumerable<User> GetUsers()
    {
        return _users;
    }

    public IEnumerable<User> GetUsers(int pageNumber, int recordsPerPage, SortOrder order)
    {
        var changedCollection = _users.Skip((pageNumber - 1) * recordsPerPage).Take(recordsPerPage);

        if (order == SortOrder.ASC)
        {
            return changedCollection.OrderBy(item => item.CreatedAt);
        }
        if (order == SortOrder.DESC)
        {
            return changedCollection.OrderByDescending(item => item.CreatedAt);
        }

        return _users;
    }

    public int GetUsersCount()
    {
        return _users.Count();
    }


    // add new book to library
    public void AddBookToLibrary(Book newBook, INotificationService notification)
    {
        bool bookExists = _books.Any(book => book.Title == newBook.Title);
        if (!bookExists)
        {
            _books = _books.Append(newBook);
            notification.SendNotificationOnSuccess($"book titled {newBook.Title} has been successfully added");

        }
        else
        {
            notification.SendNotificationOnFailure("adding this book");
        }
    }

    // add new user to library
    public void AddUserToLibrary(User newUser, INotificationService notification)
    {
        var userExists = _users.Any(user => user.Name == newUser.Name);
        if (!userExists)
        {
            _users = _users.Append(newUser);
            notification.SendNotificationOnSuccess($"user named {newUser.Name} has been successfully added");
        }
        else
        {
            notification.SendNotificationOnFailure("adding this user");
        }
    }

    // find book by title
    public Book FindBookByTitle(string title)
    {
        Book? targetBook = _books.FirstOrDefault(book => book.Title == title);
        if (targetBook is null)
        {
            Console.WriteLine("Book is not available...");
        }
        return targetBook;
    }

    // find user by name
    public User FindUserByName(string name)
    {
        User? targetUser = _users.FirstOrDefault(user => user.Name == name);
        if (targetUser is null)
        {
            Console.WriteLine("User is not available...");
        }
        return targetUser;
    }


    // delete book by id
    public IEnumerable<Book> RemoveBookById(Guid id, INotificationService notification)
    {
        Book? targetBook = _books.FirstOrDefault(book => book.Id == id);
        if (targetBook is not null)
        {
            _books = _books.Where(book => book.Id != id);
            notification.SendNotificationOnSuccess($"book with id: {id} -  has been successfully removed");
            return _books;
        }
        notification.SendNotificationOnFailure($"removing book with id {id}");
        return _books;
    }

    // delete user by id
    public IEnumerable<User> RemoveUserById(Guid id, INotificationService notification)
    {
        User? targetUser = _users.FirstOrDefault(user => user.Id == id);
        if (targetUser is not null)
        {
            _users = _users.Where(user => user.Id != id);
            notification.SendNotificationOnSuccess($"user with id: {id} - has been removed");
            return _users;
        }
        notification.SendNotificationOnFailure("removing user with id {id}");
        return _users;
    }

}