using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace AspNETMvcExperiment.Controllers
{
	public class TestController : Controller
	{
		public ActionResult Create() 
		{
			return View ();
		}

		[HttpPost]
		public ActionResult Create(string name, string description) 
		{
			ViewBag.name = name;
			ViewBag.description = description;

			return View ("Result");
		}
	}
}