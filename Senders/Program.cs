using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.NotificationHubs;

namespace Senders
{
    public class Program
    {
        private static NotificationHubClient hub;

       public static void Main(string[] args)
        {
            hub = NotificationHubClient.CreateClientFromConnectionString("Endpoint=sb://emiliohub.servicebus.windows.net/;SharedAccessKeyName=DefaultFullSharedAccessSignature;SharedAccessKey=mMZNqKuvGsbBHipZPW90C1OQmm0o3MiPjNvsYrDzuBM=","emilio");

            do
            {
                Console.WriteLine("Type a new message");
                var message = Console.ReadLine();
                SendNotificationAsync(message);
                Console.WriteLine("The message was send.....");
            } while (true);
        }

        private async static void SendNotificationAsync(string message)
        {
            await hub.SendGcmNativeNotificationAsync("{ \"data\" : {\"message\":\"" + message + "\"}}");
        }
    }
}
