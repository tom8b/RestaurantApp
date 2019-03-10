using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestaurationApp.Services.Interfaces;
using RestaurationApp.ViewModels;

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
            var model = new MenuViewModel();
            model.Dishes = _dish.GetAll();
            return View(model);
        }

        public IActionResult Cuisines()
        {
            var model = new CuisinesViewModel();
            model.cuisines = _dish.GetAllCuisines();
            return View(model);
        }
        /// <summary>
        /// Zwraca wszystkie dania z danej kuchni
        /// </summary>
        /// <param name="Id">Parametr okresla id kuchni</param>
        /// <returns></returns>
        public IActionResult Cuisine(int Id)
        {
            var model = new MenuViewModel();
            model.Dishes = _dish.GetDishesFromCuisine(Id);
            return View(model);
        }

        public IActionResult DishDetail(int Id)
        {
            var model = _dish.GetDishDetailObject(Id);

            return View(model);
        }
    }
}