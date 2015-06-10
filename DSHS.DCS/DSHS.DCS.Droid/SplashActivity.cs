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

namespace DSHS.DCS.Droid
{
   [Activity(Label = "DSHS_DCS", // app label 
			 Theme = "@style/Theme.Splash", //Indicates the theme to use for this activity
			 Icon = "@drawable/DCSIcon", //app Icon
			 MainLauncher = true, //Set it as boot activity
			 NoHistory = true)] //Doesn't place it in back stack
   public class SplashActivity : Activity
   {
	  protected override void OnCreate(Bundle bundle)
	  {
		 base.OnCreate(bundle);

		 SetContentView(Resource.Layout.SplashLayout);
		 System.Threading.ThreadPool.QueueUserWorkItem(o => LoadActivity());   

		 // Create your application here
		 //System.Threading.Thread.Sleep(3000); //Let's wait awhile...
		 //this.StartActivity(typeof(MainActivity));
	  }
	  private void LoadActivity()
	  {
		 System.Threading.Thread.Sleep(1000); // Simulate a long pause   2 seconds 
		 RunOnUiThread(() => StartActivity(typeof(MainActivity)));
	  }
	  ///// <summary>
	  ///// Add Animation Loading...
	  ///// </summary>
	  ///// <param name="hasFocus"></param>
	  //public override void OnWindowFocusChanged(bool hasFocus)
	  //{
	  //   ImageView imageView = FindViewById<ImageView>(Resource.Id.loadinganimation);

	  //   Android.Graphics.Drawables.AnimationDrawable animation = (Android.Graphics.Drawables.AnimationDrawable)imageView.Drawable;

	  //   animation.Start();
	  //}  
   }
}