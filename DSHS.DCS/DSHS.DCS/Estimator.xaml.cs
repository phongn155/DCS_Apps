using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DSHS.DCS
{
   public partial class Estimator : ContentPage
   {
	  public Estimator()
	  {
		 //InitializeComponent();
		 //Label header = new Label
		 //{
		 //   Text = "WebView",
		 //   Font = Font.BoldSystemFontOfSize(50),
		 //   HorizontalOptions = LayoutOptions.Center
		 //};		 
		 WebView webView = new WebView
		 {
			Source = new UrlWebViewSource
			{
			   Url = "https://fortress.wa.gov/dshs/dcs/SSGen/Home/QuickEstimator",
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
