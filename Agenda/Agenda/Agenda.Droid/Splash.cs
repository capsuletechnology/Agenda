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

namespace Agenda.Droid
{
    [Activity(Theme = "@style/MainSplash",  //Indicates the theme to use for this activity
                MainLauncher = true,//set it as boot activity
                NoHistory = true)]//Doesn't place it in back stack
    public class Splash : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            System.Threading.Thread.Sleep(100); //Let's wait a while...
            this.StartActivity(typeof(MainActivity));
        }
    }
}