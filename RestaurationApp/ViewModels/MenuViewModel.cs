using RestaurationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurationApp.ViewModels
{
    public class MenuViewModel
    {
        public IEnumerable<Dish> Dishes { get; set; }
    }
}
