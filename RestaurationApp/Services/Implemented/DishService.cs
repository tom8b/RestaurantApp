using RestaurationApp.Models;
using RestaurationApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurationApp.Services
{

    public class DishService : IDishService
    {
        private RestaurantContext _context;

        public DishService(RestaurantContext context)
        {
            _context = context;
        }

        public IEnumerable<Dish> GetAll()
        {
            return _context.Dishes.ToList();
        }

        public Dish GetDishById(int id)
        {
            return _context.Dishes.FirstOrDefault(dish => dish.Id == id);
        }

        
    }
}
