using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace DSHS.DCS
{
   public partial class OfficeDetails : ContentPage
   {
	  public OfficeDetails(Data.OfficeMetadata officeMetadata)
	  {
		 BindingContext = officeMetadata;
		 InitializeComponent();
		 this.BackgroundColor = Color.FromHex("#F5F5F5");
		 //lblPhone.GestureRecognizers.Add(new TapGestureRecognizer
		 //{			
		 //   Command = new Command (() => OnCall(lblPhone.Text)),
		 //});

		 //lblPhoneTDD.GestureRecognizers.Add(new TapGestureRecognizer
		 //   {
		 //	  Command = new Command(() => OnCall(lblPhoneTDD.Text)),
		 //   });

		 //lblPhysicalAddress.GestureRecognizers.Add(new TapGestureRecognizer
		 //   {
		 //	 Command = new Command(() => LaunchMap()),
		 //   });
		 		 
	  }
	  private async void OnCall(string pNumber)
	  {
		 string phoneNumber = pNumber.Replace(">", string.Empty);
		 if (await this.DisplayAlert(	
			"Dial a number",
			phoneNumber,
			"Call",
			"Cancel"))
		 {
			var dialer = DependencyService.Get<IDialer>();
			if (dialer != null)
			{
			   dialer.Dial(phoneNumber);
			}
		 }
	  }
	  private void btnPhoneClicked(object sender, EventArgs e)
	  {
		 //OnCall(lblPhone.Text);
	  }

	  private void btnPhoneTDDClicked(object sender, EventArgs e)
	  {
		 //OnCall(lblPhoneTDD.Text);
	  }

	  private void btnPhysicalAddressClicked(object sender, EventArgs e)
	  {
		 //OnCall(lblPhone.Text);
	  }
	  private void btnEmailClicked(object sender, EventArgs e)
	  {
		 //OnCall(lblPhone.Text);
	  }
	  private void btnOfficePhoneClicked(object sender, EventArgs e)
	  {
		 //OnCall(lblOfficePhone.Text);
	  }
	  private void btnOfficePhone1800Clicked(object sender, EventArgs e)
	  {
		 //OnCall(lblOfficePhone1800.Text);
	  }
	  private void LaunchMap()
	  {
		 Place place = new Place();
		 place.Name = "243 Israel Road Tumwater, WA";
		 place.Vicinity = "Tumwater";


		 var name = place.Name.Replace("&", "and"); // var name = Uri.EscapeUriString(place.Name);
		 var loc = string.Format("{0},{1}", 46.984193, -122.904856);
		 var addr = Uri.EscapeUriString(place.Vicinity);

		 //var loc = string.Format("{0},{1}", 46.984193, -122.904856);
		 //var addr = Uri.EscapeUriString("243 Israel Road Tumwater, WA 98501");

		 var request = Device.OnPlatform(
			// iOS doesn't like %s or spaces in their URLs, so manually replace spaces with +s
			string.Format("http://maps.apple.com/maps?q={0}&sll={1}", name.Replace(' ', '+'), loc),

			// pass the address to Android if we have it
			string.Format("geo:0,0?q={0}({1})", string.IsNullOrWhiteSpace(addr) ? loc : addr, name),

			// WinPhone
			string.Format("bingmaps:?cp={0}&q={1}", loc, name)
			);
		 Device.OpenUri(new Uri(request));
	  }
   }
   public class Place
   {
	  public string Name { get; set; }
	  public string Vicinity { get; set; }
	  public Geocoder Location { get; set; }
	  public Uri Icon { get; set; }
   }
}
