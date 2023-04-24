
using Task3.DataAccess;
using Task3.Models;
using Task3.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Task3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel
            {
                Features = Data.Features
            };
            return View(vm);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
