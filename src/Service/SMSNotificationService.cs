public class SMSNotificationService : INotificationService
{
    public void SendNotificationOnSuccess(string message)
    {
        Console.WriteLine($"{message} to Library. Thank you!");
    }

    public void SendNotificationOnFailure(string message)
    {
        Console.WriteLine($"Error {message} to Library. Please email support@library.com.");
    }
}