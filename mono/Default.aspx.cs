//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;



namespace mono
{
	public partial class Default : System.Web.UI.Page
	{
		
		public void button1Clicked (object sender, EventArgs args)
		{
			button1.Text = MySqlDBUtil.ExecuteScalar("select name from my;");
		}
	}
}
