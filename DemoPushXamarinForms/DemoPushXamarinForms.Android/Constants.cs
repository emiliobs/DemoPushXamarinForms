using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace DemoPushXamarinForms.Droid
{
    public static class Constants
    {
        public const string SenderID               = "76020943871"; //google api project number:
        public const string ListenConnectionString = "Endpoint=sb://emiliohub.servicebus.windows.net/;SharedAccessKeyName=DefaultFullSharedAccessSignature;SharedAccessKey=mMZNqKuvGsbBHipZPW90C1OQmm0o3MiPjNvsYrDzuBM=";
        public const string NotificationHubName    = "emilio";


    }
}