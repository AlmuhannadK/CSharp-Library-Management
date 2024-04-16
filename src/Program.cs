internal class Program
{
    private static void Main()
    {

        User user1 = new("Ali", new DateTime(2023, 1, 1));
        User user2 = new("Khalid");

        Console.WriteLine(user1.CreatedAt);
        Console.WriteLine(user2.CreatedAt);

        // example 
        // var bookDeleted = books.RemoveBook(book1.Id)
        // book1.id => Guid 

    }
}