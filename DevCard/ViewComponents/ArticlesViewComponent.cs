using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard.ViewComponents
{
	public class ArticlesViewComponent:ViewComponent
	{
		public IViewComponentResult Invoke(string name)

		{
			var articles = new List<Article>
			{
				new Article(1, "تاکسی", "درخواست آنلاین تاکسی برای سفر های درون شهری", "blog-post-thumb-1.jpg"),
				new Article(2, "زودفود", "درخواست آنلاین غذا برای سراسر کشور", "blog-post-thumb-2.jpg"),
				new Article(3, "مدارس", "سیستم مدیریت یکپارچه مدارس", "blog-post-thumb-3.jpg"),
				new Article(4, "فضاپیما", "برنامه مدیریت فضاپیما های ناسا", "blog-post-thumb-4.jpg"),
			};
			return View("_articles",articles);	
		}
		 
	}
}
