using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DSHS.DCS
{
   public partial class MorePage : ContentPage
   {
	  public MorePage()
	  {
		 InitializeComponent();
		 this.BackgroundColor = Color.FromHex("#52A4A2");
		 var listView = new ListView();
		 listView.ItemsSource = new[] { 
			"Resources",
			@"Event Calendar",
			@"Feedback",		
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
			   case "Resources":
				  Navigation.PushAsync(new Resources());
				  break;
			   case "Event Calendar":
				  Navigation.PushAsync(new EventCalendar());
				  break;
			   case "Feedback":
				  //Navigation.PushAsync(new Payment());
				  break;			   
			   default:
				  break;
			}
		 };

		 Padding = new Thickness(0, 20, 0, 0);
		 Content = listView;
	  }
   }
}
