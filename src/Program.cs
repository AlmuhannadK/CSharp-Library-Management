internal class Program
{
    private static void Main()
    {

        User user1 = new("Ali", new DateTime(2023, 1, 1));
        User user2 = new("Khalid");

        Book book1 = new("Intro to C#");
        Book book2 = new("Advanced C#");

        Library library = new();

        // add user test
        library.AddUserToLibrary(user1);
        library.AddUserToLibrary(user2);

        library.AddUserToLibrary(user1);
        var test = new User("Khalid44");
        library.AddUserToLibrary(test);

        // add book test 
        library.AddBookToLibrary(book1);
        library.AddBookToLibrary(book2);


        // find book by title test
        var targetBook1 = library.FindBookByTitle("Intro to C#");
        Console.WriteLine($"Searched for book by title: {targetBook1.Title}");

        // find user by name test 
        var targetUser1 = library.FindUserByName("Ali");
        Console.WriteLine($"Searched for user by name: {targetUser1.Name}");

        ///////////////////////////////////////////

        // get books & users collection, and number of elements test
        var books = library.GetBooks();
        var users = library.GetUsers();

        Console.WriteLine($"The number of books in library is: {library.GetBooksCount()}");
        foreach (var item in books)
        {
            Console.WriteLine(item.Title);
        }

        Console.WriteLine($"The number of users in library is: {library.GetUsersCount()}");
        foreach (var item in users)
        {
            Console.WriteLine(item.Name);
        }

        ///////////////////////////////////////////

        // delete book & user by id
        var deleteBook = library.RemoveBookById(book1.Id);

        Console.WriteLine($"The number of books in library is: {library.GetBooksCount()}");
        foreach (var item in deleteBook)
        {
            Console.WriteLine(item.Title);
        }

        


    }
}