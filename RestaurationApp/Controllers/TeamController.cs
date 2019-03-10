using Microsoft.AspNetCore.Mvc;
using RestaurationApp.Models;
using RestaurationApp.Services.Interfaces;
using RestaurationApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurationApp.Controllers
{
    public class TeamController : Controller
    {
        private IPersonService _person;

        public TeamController(IPersonService person)
        {
            _person = person;
        }

        public IActionResult OurStuff()
        {
            var model = new StuffViewModel();
            model.People = _person.GetAllPeople();

            return View(model);
        }
    }
}
