public class Library
{
    private IEnumerable<Book> _books;
    private IEnumerable<User> _users;

    public Library()
    {
        _books = [];
        _users = [];
    }


    // Get all books
    public IEnumerable<Book> GetBooks()
    {
        return _books;
    }

    // Get all users
    public IEnumerable<User> GetUsers()
    {
        return _users;
    }

    // Number of elements in books
    public int GetBooksCount()
    {
        return _books.Count();
    }
    // Number of elements in users
    public int GetUsersCount()
    {
        return _users.Count();
    }


    // add new book to library
    public void AddBookToLibrary(Book newBook)
    {
        bool bookExists = _books.Contains(_books.FirstOrDefault(book => book.Title == newBook.Title));
        if (!bookExists)
        {
            _books = _books.Append(newBook);
            Console.WriteLine("New Book Added to Library");
        }
        else
        {
            Console.WriteLine("Book Already Exists in Library");
        }
    }

    // add new user to library
    public void AddUserToLibrary(User newUser)
    {
        bool userExists = _users.Contains(_users.FirstOrDefault(user => user.Name == newUser.Name));
        if (!userExists)
        {
            _users = _users.Append(newUser);
            Console.WriteLine("New User Added to Library");
        }
        else
        {
            Console.WriteLine("User Already Exists in Library");
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
    public IEnumerable<Book> RemoveBookById(Guid id)
    {
        Book? targetBook = _books.FirstOrDefault(book => book.Id == id);
        if (targetBook is not null)
        {
            _books = _books.Where(book => book.Id != id);
            return _books;
        }
        Console.WriteLine("Book Does Not Exist...");
        return _books;
    }

    // delete user by id
    public IEnumerable<User> RemoveUserById(Guid id)
    {
        User? targetUser = _users.FirstOrDefault(user => user.Id == id);
        if (targetUser is not null)
        {
            _users = _users.Where(user => user.Id != id);
        }
        Console.WriteLine("User Does Not Exist...");
        return _users;
    }



    // get all books with pagination, sorted by created date

    // get all users with pagination, sorted by created date


}

/*
 Logic to Implement Paging
                        var employees = Employee.GetAllEmployees() //Data Source
                                    .Skip((PageNumber - 1) * RecordsPerPage) //Skip Logic
                                    .Take(RecordsPerPage).ToList();
*/