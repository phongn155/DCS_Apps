using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DSHS.DCS
{
   public class Main : ContentPage
   {
	  public Main()
	  {
		 //Label header = new Label
		 //{
		 //   Text = "DSHS DCS",
		 //   FontSize = 40,
		 //   FontAttributes = FontAttributes.Bold,
		 //   HorizontalOptions = LayoutOptions.Center

		 //};
		 		 
		 var header = new Image() 
		 { 
			Source = ImageSource.FromFile("DCS.png"),
			HorizontalOptions = LayoutOptions.CenterAndExpand	 
		 };
		 		 		
		 Button btnContactUs = new Button
		 {
			Text = "Services         >",
			TextColor = Color.White,
			FontAttributes = FontAttributes.Bold,
			BackgroundColor = Color.White,
			BorderColor = Color.Gray,
			Font =  Font.SystemFontOfSize(NamedSize.Large),
			HorizontalOptions = LayoutOptions.StartAndExpand,
			BorderWidth = 1
		 };
		 btnContactUs.Clicked += async (sender, args) =>
			 await Navigation.PushAsync(new ContactUs());

		 Button btnFindOffice = new Button
		 {
			Text = "ESA Offices          >",
			TextColor = Color.Black,
			FontAttributes = FontAttributes.Bold,
			BackgroundColor = Color.White,
			BorderColor = Color.Gray,
			Font = Font.SystemFontOfSize(NamedSize.Large),
			HorizontalOptions = LayoutOptions.StartAndExpand,
			BorderWidth = 1
		 };
		 btnFindOffice.Clicked += async (sender, args) =>
			 await Navigation.PushAsync(new FindOfficeResult());

		 //Button btnPaymentOption = new Button
		 //{
		 //   Text = "Payment Options         >",
		 //   TextColor = Color.Black,
		 //   FontAttributes = FontAttributes.Bold,
		 //   BackgroundColor = Color.White,
		 //   BorderColor = Color.Gray,
		 //   Font = Font.SystemFontOfSize(NamedSize.Large),
		 //   HorizontalOptions = LayoutOptions.StartAndExpand,
		 //   BorderWidth = 1
		 //};
		 //btnPaymentOption.Clicked += async (sender, args) =>
		 //	await Navigation.PushAsync(new PaymentOption());

		 Button btnEstimator = new Button
		 {
			Text = "Child Support Estimator     >",
			TextColor = Color.Black,
			FontAttributes = FontAttributes.Bold,
			BackgroundColor = Color.White,
			BorderColor = Color.Gray,
			Font = Font.SystemFontOfSize(NamedSize.Large),
			HorizontalOptions = LayoutOptions.StartAndExpand,
			BorderWidth = 1
		 };
		 btnEstimator.Clicked += async (sender, args) =>
			 await Navigation.PushAsync(new Estimator());

		 Button btnResources = new Button
		 {
			Text = "Resources     >",
			TextColor = Color.Black,
			FontAttributes = FontAttributes.Bold,
			BackgroundColor = Color.White,
			BorderColor = Color.Gray,
			Font = Font.SystemFontOfSize(NamedSize.Large),
			HorizontalOptions = LayoutOptions.StartAndExpand,
			BorderWidth = 1
		 };
		 btnResources.Clicked += async (sender, args) =>
			 await Navigation.PushAsync(new Resources());


		 Button btnEventCalendar = new Button
		 {
			Text = "Event Calendar     >",
			TextColor = Color.Black,
			FontAttributes = FontAttributes.Bold,
			BackgroundColor = Color.White,
			BorderColor = Color.Gray,
			Font = Font.SystemFontOfSize(NamedSize.Large),
			HorizontalOptions = LayoutOptions.StartAndExpand,
			BorderWidth = 1
		 };
		 btnEventCalendar.Clicked += async (sender, args) =>
			 await Navigation.PushAsync(new EventCalendar());

		 		 

		 // Build the page.
		 this.Content = new StackLayout
		 {
			Children = 
                {
                    header,
                    new StackLayout
                    {
					   BackgroundColor= Color.White,
                        HorizontalOptions = LayoutOptions.Center,
                        Children = 
                        {
                            btnContactUs,
							btnFindOffice,							
							btnEstimator,
							btnResources,
                            btnEventCalendar,                                                        
                        }
                    }
                }
		 };
	  }
   }
}
