using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;

namespace DSHS.DCS
{
   public class UnevenRowsCell : ViewCell
   {
	  public UnevenRowsCell()
	  {
		 var label1 = new Label
		 {
			Text = "Label 1",
			FontAttributes = FontAttributes.Bold,
			HorizontalOptions = LayoutOptions.FillAndExpand,
			FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
		 };
		 var label2 = new Label
		 {
			Text = ">",
			FontAttributes = FontAttributes.Bold,
			HorizontalOptions = LayoutOptions.EndAndExpand,
			FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
		 };

		 label1.SetBinding(Label.TextProperty, new Binding("."));
		 label1.TextColor = Color.White;
		 label2.TextColor = Color.White;

		 View = new StackLayout
		 {
			//BackgroundColor = Color.Silver,
			Orientation = StackOrientation.Horizontal,
			VerticalOptions = LayoutOptions.CenterAndExpand,			
			Padding = new Thickness(15, 5, 5, 5),
			Children = { label1, label2 }					
		 };
	  }
   }
}
