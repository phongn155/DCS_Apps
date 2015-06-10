using System;
using Xamarin.Forms;
using System.Reflection;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace DSHS.DCS
{
   public partial class ServiceContentPage : ContentPage
   {
	  private List<DSHS.DCS.Data.ServiceBO> mServiceList;
	  private string mDetails;
	  public ServiceContentPage(Data.ServiceBO service)
	  {
		 InitializeComponent();
		 this.BackgroundColor = Color.FromHex("#E0E5E0");
		 this.Title = service.Name;

		 ParseXmlService();
		 //check mServiceList
		 if (mServiceList.Count > 0 && mServiceList != null)
		 {			
			List<Data.ServiceBO> sList = mServiceList.Where(m => m.Name.Contains(service.Name)).ToList();

			if (sList.Count > 0 && sList != null)
			mDetails = sList[0].Details.ToString();
		 }

		 Label label = new Label
		 {
			Text = mDetails,
			TextColor = Color.Black,				
			FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
			VerticalOptions = LayoutOptions.StartAndExpand
		 };

		 // Build the page.
		 this.Content = new StackLayout
		 {
			Children = 
                {                    
                    label
                }
		 };
	  }
	  private void ParseXmlService()
	  {
		 var assembly = typeof(ServiceContentPage).GetTypeInfo().Assembly;
		 Stream stream = assembly.GetManifestResourceStream("DSHS.DCS.Data.Services.xml");

		 using (var reader = new System.IO.StreamReader(stream))
		 {
			XmlSerializer serializer = new XmlSerializer(typeof(List<DSHS.DCS.Data.ServiceBO>), new XmlRootAttribute("Services"));
			mServiceList = (List<DSHS.DCS.Data.ServiceBO>)serializer.Deserialize(reader);
		 }
	  }
   }
}
