using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace AspNETMvcExperiment.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index ()
		{
			var mvcName = typeof(Controller).Assembly.GetName ();
			var isMono = Type.GetType ("Mono.Runtime") != null;

			ViewData ["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
			ViewData ["Runtime"] = isMono ? "Mono" : ".NET";

			ViewBag.Test = "This is a test";

			return View ();
		}

		[HttpPost]
		public JsonResult Elements()
		{
			String[] elements = { "First", "Second", "Third", "Fourth"};

			return Json (new {
				title = "Element list",
				elementList = elements
			});
		}
	}
}

