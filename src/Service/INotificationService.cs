public interface INotificationService
{

    public void SendNotificationOnSuccess(string message);

    public void SendNotificationOnFailure(string message);
}