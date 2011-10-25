using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JavascriptSandbox.Controllers
{
    public class SandboxController : Controller
    {
        public ActionResult Index( string sandboxViewName)
        {
            return View( sandboxViewName);
        }
    }
}
