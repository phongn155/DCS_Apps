﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSHS.DCS
{
   public interface IDialer
   {
	  bool Dial(String number);
   }
}
