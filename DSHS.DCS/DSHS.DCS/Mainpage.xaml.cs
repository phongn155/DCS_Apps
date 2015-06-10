using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DSHS.DCS
{
   public partial class Mainpage : ContentPage
   {
	  public Mainpage()
	  {
		 InitializeComponent();
		 //this.BackgroundImage = ImageSource.FromFile("");

		 var header = new Image()
		 {
			Source = ImageSource.FromFile("Background.png"),
			HorizontalOptions = LayoutOptions.CenterAndExpand,
			VerticalOptions = LayoutOptions.Center
		 };

		 // Build the page.
		 this.Content = new StackLayout
		 {
			Children = 
                {
                    header,
					new StackLayout
					{
					   BackgroundColor= Color.White,
						//HorizontalOptions = LayoutOptions.Center,
						Children = 
						{
							header                                                       
						}
					}
                }
		 };

	  }
	  void OnClick(object sender, EventArgs e)
	  {
		 ToolbarItem tbi = (ToolbarItem)sender;
		 		 
		 string str = tbi.Text;
		 switch (str)
		 {
			case "Services" :
			   Navigation.PushAsync(new Services());
			   break;
			case "Location" :
			   Navigation.PushAsync(new FindOfficeResult());
			   break;
			case "Payment":
			   Navigation.PushAsync(new Payment());
			   break;
			case "Estimator":
			   Navigation.PushAsync(new Estimator());
			   break;
			case "More...":
			   Navigation.PushAsync(new MorePage());
			   break;
			default:
			   break;
		 }
	  }
   }
}
