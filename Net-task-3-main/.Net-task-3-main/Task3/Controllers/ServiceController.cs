using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using Task3.DataAccess;
using Task3.Models;
using Task3.ViewModels;

namespace Task3.Controllers
{
    public class ServiceController : Controller
    {
        private readonly DataContext _context;

        public ServiceController(DataContext context) 
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //List<SerFeature> SerFeatures = _context.Table_1.ToList();

            //ServiceViewModel svm = new ServiceViewModel { 
            //    SerFeatures = Data.SerFeatures
            //};

            ServiceViewModel serviceViewModel= new ServiceViewModel();

            serviceViewModel.SerFeatures = _context.Table_1.ToList();

            return View(serviceViewModel);
        }

        public IActionResult Deatil(int id)
        {
            SerFeature serFeature = _context.Table_1.FirstOrDefault(x => x.Id == id);  

            return View(serFeature);
        }
        
    }
}
