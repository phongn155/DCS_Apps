using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DSHS.DCS
{
   public class MenuListData : List<MenuItem>
   {
	  public MenuListData()
	  {
		 this.Add(new MenuItem()
		 {
			Title = "",			
			IconSource = "contacts.png",
			TargetType = typeof(ContactUs) 
		 });

		 this.Add(new MenuItem()
		 {
			Title = "",
			IconSource = "leads.png",
			TargetType = typeof(FindOfficeResult)
		 });
		 

		 this.Add(new MenuItem()
		 {
			Title = "",
			IconSource = "accounts.png",
			TargetType = typeof(Estimator)
		 });
	  }
   }
}
