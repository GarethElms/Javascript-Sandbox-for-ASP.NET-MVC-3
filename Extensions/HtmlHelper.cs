using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JavascriptSandbox.Extensions
{
	public static class HtmlHelperExtensions
	{
		 public static MvcHtmlString SandboxLink( this HtmlHelper helper, string sandboxViewName, string description)
		 {
			var urlHelper = new UrlHelper( helper.ViewContext.RequestContext);
			return new MvcHtmlString(
						string.Format(
							"<a href=\"{0}\">{1}</a>",
							urlHelper.Action( "Index", "Sandbox", new {sandboxViewName = sandboxViewName}),
							description));
		 }

		 public static MvcHtmlString Credit_CodyLindley( this HtmlHelper helper)
		 {
			return new MvcHtmlString( "<p>Some credit must go to <a href=\"http://www.javascriptenlightenment.com\">Javascript Enlightenment</a> by <a href=\"http://codylindley.com\">Cody Lindley</a>. Brilliant book</p>");
		 }

		 public static MvcHtmlString Credit_AlexMacCaw( this HtmlHelper helper)
		 {
			return new MvcHtmlString( "<p>Some credit must go to <a href=\"http://shop.oreilly.com/product/0636920018421.do\">Javascript Web Applications</a> by <a href=\"http://alexmaccaw.co.uk\">Alex MacCaw</a>. Brilliant book</p>");
		 }
	}
}