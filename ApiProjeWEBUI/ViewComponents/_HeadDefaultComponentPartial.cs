using Microsoft.AspNetCore.Mvc;

namespace ApiProjeWEBUI.ViewComponents
{
	public class _HeadDefaultComponentPartial : ViewComponent
	{
		public  IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
