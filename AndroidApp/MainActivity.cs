﻿using Android.App;
using Android.Widget;
using Android.OS;

namespace AndroidApp
{
    [Activity(Label = "AndroidApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            var Validator = new PCLProyect.AppValidator(new AndroidDialog(this));
            Validator.EMail = "shadowghost-1996@hotmail.com";
            Validator.Password = "santuario1";
            Validator.Device = Android.Provider.Settings.Secure.GetString(ContentResolver,Android.Provider.Settings.Secure.AndroidId);
            Validator.Validate();
            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

