using System;

namespace Task6.services
{
    public class NotificationService
    {
        public void SendNotification(int count)
        {
            Console.WriteLine($"[Notification] Admin notified for {count} orders.");
        }
    }
}

