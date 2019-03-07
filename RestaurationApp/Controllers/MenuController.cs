using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestaurationApp.Services.Interfaces;

namespace RestaurationApp.Controllers
{
    public class MenuController : Controller
    {
        private IDishService _dish;

        public MenuController(IDishService dish)
        {
            _dish = dish;
        }

        public IActionResult Index()
        {
            var model = _dish.GetAll();
            return View(model);
        }
    }
}