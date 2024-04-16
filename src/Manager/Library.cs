public class Library
{
    private readonly IEnumerable<Book> _books;
    private readonly IEnumerable<User> _users;

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

    // find book by title
    public Book FindBookByTitle(string title)
    {
        Book? targetBook = _books.ToList().Find((book) => book.Title == title);
        if (targetBook is null)
        {
            Console.WriteLine("Book Not Found!");
        }
        return targetBook;
    }

    // find user by name
    public User FindUserByName(string name)
    {
        User? targetUser = _users.ToList().Find((user) => user.Name == name);
        if (targetUser is null)
        {
            Console.WriteLine("User Not Found");
        }
        return targetUser;
    }

    // add new book to library
    public void AddBookToLibrary(Book newBook)
    {
        bool bookExists = _books.Contains(newBook);
        if (!bookExists)
        {
            _books.Append(newBook);
            Console.WriteLine("New Book Added");
        }
        Console.WriteLine("Book Already Exists in Library");
    }

    // add new user to library
    public void AddUserToLibrary(User newUser)
    {
        bool userExists = _users.Contains(newUser);
        if (!userExists)
        {
            _users.Append(newUser);
            Console.WriteLine("New Users Added To Library");
        }
        Console.WriteLine("User Already Exists in Library");
    }


    // delete book by id
    public IEnumerable<Book> RemoveBookById(Guid id)
    {
        Book? targetBook = _books.FirstOrDefault(book => book.Id == id);
        if (targetBook is not null)
        {
            IEnumerable<Book> newCollection = _books.Where(book => book.Id != id);
            return newCollection;
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
            IEnumerable<User> newCollectin = _users.Where(user => user.Id != id);
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