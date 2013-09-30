using System.Web.Mvc;

namespace MvcGlimpseApplication.Filters
{
	public sealed class TestFilter : FilterAttribute, IResultFilter
	{
		public void OnResultExecuting(ResultExecutingContext filterContext)
		{
		}

		public void OnResultExecuted(ResultExecutedContext filterContext)
		{
			var response = filterContext.HttpContext.Response;
			response.Filter = new TestStream(response.Filter);
		}
	}
}
