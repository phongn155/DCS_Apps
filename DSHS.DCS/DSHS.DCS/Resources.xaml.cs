using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DSHS.DCS
{
   public partial class Resources : ContentPage
   {
	  public Resources()
	  {
		 InitializeComponent();
		 this.BackgroundColor = Color.FromHex("#52A4A2");
		 var listView = new ListView();
		 listView.ItemsSource = new[] { 
			"Tribal",
			@"Veterans",
			@"Federal",	
			@"Alternative Solutions",
			@"Social Media",
			};
		 listView.ItemTemplate = new DataTemplate(typeof(UnevenRowsCell));

		 listView.ItemTapped += (sender, e) =>
		 {
			if (e == null) return;
			//Data.ServiceBO serviceMetadata = new Data.ServiceBO();
			//serviceMetadata.Name = e.Item.ToString();
			//Navigation.PushAsync(new ServiceContentPage(serviceMetadata));
			switch (e.Item.ToString())
			{
			   case "Tribal":
				  viewResources("https://www.dshs.wa.gov/esa/division-child-support/tribal-relations");
				  break;
			   case "Veterans":
				  viewResources("https://www.dshs.wa.gov/esa/division-child-support/veterans");
				  break;
			   case "Federal":
				  viewResources("http://www.acf.hhs.gov/programs/css");			   
				  break;
			   case "Alternative Solutions":

				  break;
			   case "Social Media":
				  viewResources("http://www.facebook.com/Division.of.Child.Support");
				  break;
			   default:
				  break;
			}
		 };

		 Padding = new Thickness(0, 20, 0, 0);
		 Content = listView;
	  }
	  private void viewResources(string resourceUrl)
	  {
		 WebView webView = new WebView
		 {
			Source = new UrlWebViewSource
			{
			   Url = resourceUrl,
			},

			VerticalOptions = LayoutOptions.FillAndExpand,
			HorizontalOptions = LayoutOptions.FillAndExpand,

		 };

		 // Accomodate iPhone status bar.
		 //this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

		 // Build the page.
		 this.Content = new StackLayout
		 {
			Orientation = StackOrientation.Vertical,
			Children =
                {
                    //header,
                    webView
                }
		 };
	  }
   }
}
