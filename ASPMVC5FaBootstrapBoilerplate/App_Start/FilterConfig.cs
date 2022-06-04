using System.Web.Mvc;

namespace ASPMVC5FaBootstrapBoilerplate
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
