using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DSHS.DCS
{
   public class RootPage : MasterDetailPage
   {
	  public RootPage()
	  {
		 var menuPage = new MenuPage();
		 menuPage.Menu.ItemSelected += (sender, e) => NavigateTo(e.SelectedItem as MenuItem);

		 Master = menuPage;
		 //Detail = new NavigationPage(new ContractsPage());
		 Detail = new NavigationPage(new ContactUs()) { BarBackgroundColor = Color.Teal, BarTextColor=Color.White };
		

	  }

	  void NavigateTo(MenuItem menu)
	  {
		 Page displayPage = (Page)Activator.CreateInstance(menu.TargetType);
		 Detail = new NavigationPage(displayPage) {BarBackgroundColor = Color.Teal, BarTextColor = Color.White};

		 IsPresented = false;
	  }
   }
}
