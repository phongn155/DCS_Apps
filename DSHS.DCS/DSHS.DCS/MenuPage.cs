using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DSHS.DCS
{
   public class MenuPage : ContentPage
   {
	  public ListView Menu { get; set; }
	 
	  public MenuPage()
	  {
		 //Icon = "DSHSICON.png";
		 Icon = Device.OS == TargetPlatform.iOS ? "menu.png" : null;
		 Title = "menu"; // The Title property must be set.
		 BackgroundColor = Color.FromHex("333333");
		 
		 Menu = new MenuListView();
		

		 var header = new Image()
		 {
			Source = ImageSource.FromFile("DCSIcon.png")
			//HorizontalOptions = LayoutOptions.CenterAndExpand,
			//VerticalOptions = LayoutOptions.CenterAndExpand
		 };

		 //var menuLabel = new ContentView
		 //{
		 //   Padding = new Thickness(10, 36, 0, 5),
		 //   Content = new Label
		 //   {  
		 //	  Text = "MENU",
		 //	  TextColor = Color.White,
		 //   }
		 //};

		 var layout = new StackLayout
		 {
			Spacing = 0,
			VerticalOptions = LayoutOptions.FillAndExpand
			
		 };
		 layout.Children.Add(header);
		 //layout.Children.Add(menuLabel);
		 layout.Children.Add(Menu);
		 
		 Content = layout;
	  }
   }
}
