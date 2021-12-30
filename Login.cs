using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Talat
{
    [Activity(Label = "Login")]
    public class Login : Activity
    {
        Button btnLogin;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_login);
            // Create your application here
            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);

            btnLogin.Click += delegate
            {
                StartActivity(new Intent(Application.Context, typeof(Dashboard)));
            };
        }
    }
}