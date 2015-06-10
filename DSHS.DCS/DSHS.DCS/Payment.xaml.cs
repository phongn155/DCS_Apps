using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DSHS.DCS
{
   public partial class Payment : ContentPage
   {
	  public Payment()
	  {
		 InitializeComponent();
		 this.BackgroundColor = Color.FromHex("#52A4A2");
		 var listView = new ListView();
		 listView.ItemsSource = new[] { 
			"In Person",
			@"By Mail",
			@"Online",			
			};
		 listView.ItemTemplate = new DataTemplate(typeof(UnevenRowsCell));

		 listView.ItemTapped += (sender, e) =>
		 {
			if (e == null) return;
			string paymentOption = e.Item.ToString();
			Navigation.PushAsync(new PaymentOption(paymentOption));
		 };

		 Padding = new Thickness(0, 20, 0, 0);
		 Content = listView;
	  }
   }
}
