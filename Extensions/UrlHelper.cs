using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JavascriptSandbox.Extensions
{
	public static class UrlHelperExtensions
	{
		 public static string Sandbox( this UrlHelper helper, string sandboxViewName)
		 {
			return helper.Action( "Index", "Sandbox", new {sandboxViewName = sandboxViewName});
		 }
	}
}