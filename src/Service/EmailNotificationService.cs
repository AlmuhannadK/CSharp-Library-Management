public class EmailNotificationService : INotificationService
{
    public void SendNotificationOnSuccess(string message)
    {
        Console.WriteLine($"Hello, a new {message} to the Library. If you have any queries or feedback, please contact our support team at support@library.com.");
    }

    public void SendNotificationOnFailure(string message)
    {
        Console.WriteLine($"We encountered an issue {message}. Please review the input data. For more help, visit our FAQ at library.com/faq.");
    }
}