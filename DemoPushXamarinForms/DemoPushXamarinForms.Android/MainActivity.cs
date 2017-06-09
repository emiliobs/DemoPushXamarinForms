using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Util;
using Gcm.Client;

namespace DemoPushXamarinForms.Droid
{
    [Activity(Label = "DemoPushXamarinForms", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        public static MainActivity instance;
        protected override void OnCreate(Bundle bundle)
        {
            instance = this;

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());

            RegisterWithGCM();
        }

        private void RegisterWithGCM()
        {
            //Check to ensure everuthing's set up riaght:
            GcmClient.CheckDevice(this);
            GcmClient.CheckManifest(this);

            //Register for push notification:
            Log.Info("MainActivity", "Registering.....");
            GcmClient.Register(this, Constants.SenderID);

        }
    }
}

