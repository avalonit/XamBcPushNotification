using System;

namespace DynPush.Droid
{
    public class AzureNotificationConstants
    {
        // Azure app-specific connection string and hub path
        public const string ListenConnectionString = "Endpoint=sb://{your_hub_namespace}.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey={your_hub_key}";
        public const string NotificationHubName = "{your_hub_name}";

        public const string TAG = "MainActivity";
        internal static readonly string CHANNEL_ID = "my_notification_channel";
    }
}
