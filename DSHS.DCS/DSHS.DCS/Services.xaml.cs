using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DSHS.DCS
{
   public partial class Services : ContentPage
   {
	  public Services()
	  {
		 InitializeComponent();
		 this.BackgroundColor = Color.FromHex("#52A4A2");
		 var listView = new ListView();				
		 listView.ItemsSource = new[] { 
			"Paternity Establishment",
			@"Establishing Support Order",
			@"Modifying Support Orders",
			@"Enforcement or Collection",
			@"Termination of Support",
			@"Employers",
			@"Apply for Services",
			@"Frequently Asked Questions (FAQ)"	
			};
		 listView.ItemTemplate = new DataTemplate(typeof(UnevenRowsCell));

		 listView.ItemTapped += (sender, e) =>
		 {
			if (e == null) return; 	
			Data.ServiceBO serviceMetadata = new Data.ServiceBO();
			serviceMetadata.Name = e.Item.ToString();
			Navigation.PushAsync(new ServiceContentPage(serviceMetadata));
		 };
		 
		 Padding = new Thickness(0, 20, 0, 0);
		 Content = listView;
	  }
	  	 
	  //async void OnItemTapped(object sender, ItemTappedEventArgs e)
	  //{
	  //   string s = e.Item.ToString();
	  //   await this.Navigation.PushAsync(new ServiceContentPage(s));
	  //}

	  //public void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
	  //{	 
	  //   DisplayAlert("Tapped", e.SelectedItem + " row was tapped", "OK");	
	  //}
   }
}
