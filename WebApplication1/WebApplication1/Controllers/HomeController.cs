using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication1.DataAccess;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;

        public HomeController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel hvm = new HomeViewModel();

            hvm.Services = _context.Service.ToList();
            hvm.TeamMembers = _context.TeamMember.ToList();

            return View(hvm);
        }
    }
}
