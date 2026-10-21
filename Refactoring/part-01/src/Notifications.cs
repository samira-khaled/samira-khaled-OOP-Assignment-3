namespace RefactoringLab;

public interface INotificationChannel
{
      string Name { get; }

    void Send(string to, string message);

}
public class EmailNotification : INotificationChannel
{
    public string Name => "email";

    public void Send(string to, string message) =>
        Console.WriteLine($"[{Name}] {to}: {message}");
}

public class SmsNotification : INotificationChannel
{
    public string Name => "sms";

    public void Send(string to, string message) =>
        Console.WriteLine($"[{Name}] {to}: {message}");
}
public class NotificationService
{
    public DateTime SendAt { get; set; }
    private readonly INotificationChannel _channel;
    bool isUrgent= false;


    public NotificationService(INotificationChannel channel)//new EmailNotification channel access send method or new SmsNotification channel access send method
    {
        _channel = channel; // object email or sms 

    }
    public void Send(string to, string message, bool isUrgent=false, DateTime? sendAt = null)
    {
        if (isUrgent)
        {
            message = $"[URGENT] {message}";
        }
       if(sendAt.HasValue)
        {
            SendAt = sendAt.Value;
            Console.WriteLine($"[{_channel.Name}] scheduled {SendAt:g}] {to}: [URGENT] {message}");
        }
        else
        {
            _channel.Send(to, message);
        }
       
    }
    
}



