using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestaurationApp.Models;
using RestaurationApp.Services;
using RestaurationApp.Services.Interfaces;
using RestaurationApp.ViewModels;

namespace RestaurationApp.Controllers
{
    public class HomeController : Controller
    {
        private IDishService _dish;

        public HomeController(IDishService dish)
        {
            _dish = dish;
        }

        public IActionResult Index()
        {
            var model = new MenuViewModel();
            model.Dishes = _dish.GetRandomDishes(3);
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
