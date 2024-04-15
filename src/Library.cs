public class Library
{
    private readonly List<Book> _books;
    private readonly List<User> _users;

    public Library()
    {
        _books = new List<Book>();
        _users = new List<User>();
    }


    // Get all books
    public List<Book> GetBooks()
    {
        return _books;
    }

    // Get all users
    public List<User> GetUser()
    {
        return _users;
    }


    // find books by title
    public Book FindBookByTitle(string title)
    {
        Book? targetBook = _books.Find((book) => book.Title == title);
        if (targetBook is null)
        {
            Console.WriteLine("Book Not Found!");
        }
        return targetBook;
    }

    // find users by name
    public User FindUserByName(string name)
    {
        User? targetUser = _users.Find((user) => user.Name == name);
        if (targetUser is null)
        {
            Console.WriteLine("User Not Found");
        }
        return targetUser;
    }

    // add new book to library
    public bool AddBookToLibrary(Book newBook)
    {
        bool bookExists = _books.Contains(newBook);
        if (!bookExists)
        {
            _books.Add(newBook);
            Console.WriteLine("New Book Added");
            return true;
        }
        Console.WriteLine("Book Already Exists in Library");
        return false;

    }

    // add new user to library
    public bool AddUserToLibrary(User newUser)
    {
        bool userExists = _users.Contains(newUser);
        if (!userExists)
        {
            _users.Add(newUser);
            Console.WriteLine("New Users Added To Library");
            return true;
        }
        Console.WriteLine("User Already Exists in Library");
        return false;
    }

    // delete book by id

    // delete user by id



    // get all books with pagination, sorted by created date

    // get all users with pagination, sorted by created date
}

/*
 Logic to Implement Paging
                        var employees = Employee.GetAllEmployees() //Data Source
                                    .Skip((PageNumber - 1) * RecordsPerPage) //Skip Logic
                                    .Take(RecordsPerPage).ToList();
*/