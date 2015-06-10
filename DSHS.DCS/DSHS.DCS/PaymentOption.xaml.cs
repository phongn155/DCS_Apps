using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DSHS.DCS
{
   public partial class PaymentOption : ContentPage
   {
	  private string mPaymentOption;
	  public PaymentOption(string paymentOption)
	  {
		 InitializeComponent();
		 this.BackgroundColor = Color.FromHex("#F5F5F5");
		 this.Title = paymentOption;

		 	 		 
		 switch (paymentOption)
		 {
			  

			case "In Person":
			   
			   break;
			case "By Mail":
			   StringBuilder sb = new StringBuilder();	
			   sb.Append("\t");
			   sb.Append("Mail your payment to:");
			   sb.AppendLine();
			   sb.Append("\t\t\t");
			   sb.Append("DSHS / DCS");
			   sb.AppendLine();
			   sb.Append("\t\t\t");
			   sb.Append("WSSR");
			   sb.AppendLine();
			   sb.Append("\t\t\t");
			   sb.Append("PO Box 45868");
			   sb.AppendLine();
			   sb.Append("\t\t\t");
			   sb.Append("Olympia, WA 98504-5868");
			   mPaymentOption = sb.ToString();
			   break;
			case "Online":
			   PayOnline();
			   return;
			   //break;
			   
			default:
			   break;
		 }
		 
		 Label label = new Label
		 {
			Text = mPaymentOption,
			TextColor = Color.Black,
			FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
			VerticalOptions = LayoutOptions.StartAndExpand
		 };

		 // Build the page.
		 this.Content = new StackLayout
		 {
			Children = 
                {                    
                    label,					
                }
		 };
	  }
	  private void PayOnline()
	  {
		 Label label = new Label
		 {
			Text = "All payment vendors require Account Information \n\n Account Information:",
			TextColor = Color.Black,
			FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
			VerticalOptions = LayoutOptions.StartAndExpand
		 };
		 //Label label2 = new Label
		 //{
		 //   Text = "Account Information:",
		 //   TextColor = Color.Black,
		 //   FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
		 //   VerticalOptions = LayoutOptions.StartAndExpand
		 //};
		 // Build the page.
		 this.Content = new StackLayout
		 {
			Children = 
                {                    
                    label
					//label2
                }
		 };		
	  }
   }
}
