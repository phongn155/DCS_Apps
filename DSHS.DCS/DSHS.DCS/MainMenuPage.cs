using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DSHS.DCS
{
   public class MainMenuPage : ContentPage
   {
	  public MainMenuPage()
	  {
		 var header = new Image()
		 {
			Source = ImageSource.FromFile("WatermarkIcon.png"),
			HorizontalOptions = LayoutOptions.CenterAndExpand,
			VerticalOptions = LayoutOptions.CenterAndExpand
		 };

		 // Build the page.
		 this.Content = new StackLayout
		 {
			BackgroundColor = Color.White,

			//Children = 
			//	{
			//		header,
			//		new StackLayout
			//		{
			//		   BackgroundColor= Color.Aqua,
			//			HorizontalOptions = LayoutOptions.Center,                        
			//		}
			//	}
		 };
	  }	 
   }
}
