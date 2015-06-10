﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DSHS.DCS
{
   public class App : Application
   {
	  public App()
	  {
		 // The root page of your application
		 //MainPage = new NavigationPage(new Main());		 		 
		 //MainPage = new RootPage();
		 MainPage = new NavigationPage(new Mainpage()) { BarBackgroundColor = Color.FromHex("#247272"), BarTextColor = Color.White };
        }

	  protected override void OnStart()
	  {
		 // Handle when your app starts
	  }

	  protected override void OnSleep()
	  {
		 // Handle when your app sleeps
	  }

	  protected override void OnResume()
	  {
		 // Handle when your app resumes
	  }
   }
}
