using System.Web.Mvc;
using MvcGlimpseApplication.Filters;

namespace MvcGlimpseApplication.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		[TestFilter]
		public ActionResult WithLogging()
		{
			// doing a trace here will make traces later in the pipeline show up in the trace tab of the glimpse plugin
			// not doing a trace here makes the other trace entries not show up
			System.Diagnostics.Trace.WriteLine("Trace from controller", "Test");
			return View();
		}

		[TestFilter]
		public ActionResult WithoutLogging()
		{
			// we are doing no trace here, to illustrate the problem
			return View();
		}
	}
}
