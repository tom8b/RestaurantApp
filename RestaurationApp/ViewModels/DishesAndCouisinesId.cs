using RestaurationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurationApp.ViewModels
{
    public class DishesAndCouisinesId
    {
        public IEnumerable<DishAndCouisineId> dishesAndCouisineIds { get; set; }
    }

    public class DishAndCouisineId
    {
        public Dish dish { get; set; }
        public int CuisineId { get; set; }
    }
}
