using System;

namespace DynPush.iOS
{
    public class AzureNotificationConstants
    {
        // Azure app-specific connection string and hub path
        public const string ListenConnectionString = "Endpoint=sb://{your_hub_namespace}.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey={your_hub_key}";
        public const string NotificationHubName = "{your_hub_name}";
    }
}
