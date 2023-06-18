using DevCard.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using DevCard_MVC.Models;

namespace DevCard.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
           
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact();
			return View(model);
		}

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
           // if (ModelState.IsValid == false)
           if (!ModelState.IsValid)
           {
               ViewBag.error = "اطلاعات وارد شده صحیح نمی باشد";
               return View(model);
           }

           ViewBag.success = "پیغام شما با موفقیت ثبت گردید";
           return View();
           //return RedirectToAction("Index");
        }

        //for Downloadfile
        //public FileResult Index()
        //{
        //    //return File("~/test.txt", "text/html");
        //    var fileByte = System.IO.File.ReadAllBytes("wwwroot/test.txt");
        //    const string fileName = "testFile.txt";
        //    return File(fileByte, MediaTypeNames.Text.Plain, fileName);
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}