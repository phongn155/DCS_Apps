using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSHS.DCS.Data
{   
   public class ServiceBO
   {
	  string mName;
	  public string Name 
	  { 
		 get { return mName; }
		 set { mName = value; }
	  }

	  string mDetails;
	  public string Details 
	  {
		 get { return mDetails; }
		 set { mDetails = value; }
	  }

	  //public override string ToString()
	  //{
	  //   //return base.ToString();
	  //   return Name;
	  //}
   }
}
