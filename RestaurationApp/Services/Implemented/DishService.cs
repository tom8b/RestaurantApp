using Microsoft.EntityFrameworkCore;
using RestaurationApp.Models;
using RestaurationApp.Services.Interfaces;
using RestaurationApp.ViewModels;
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

        #region Dish methods
        public IEnumerable<Dish> GetAll()
        {
            return _context.Dishes.ToList();
        }

       

        public Dish GetDishById(int id)
        {
            return _context.Dishes.FirstOrDefault(dish => dish.Id == id);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="CouisineId"></param>
        /// <returns>Returns All dishes from specific cuisine</returns>
        public IEnumerable<Dish> GetDishesFromCuisine(int CouisineId)
        {
            return _context.Dishes
                .Include(d => d.Cuisine)
                .Where(d => d.Cuisine.Id == CouisineId);
        }

        public DishDetailViewModel GetDishDetailObject(int id)
        {
            var query = _context.Dishes
                .Include(d => d.TypeOfDish)
                .Include(d => d.Cuisine)
                .FirstOrDefault(d => d.Id == id);

            var dishObject = new DishDetailViewModel();

            dishObject.cost = query.Cost;
            dishObject.cuisineName = query.Cuisine.CuisineName;
            dishObject.dishDescribtion = query.Description;
            dishObject.dishName = query.DishName;
            dishObject.typeOfDish = query.TypeOfDish.Name;
            dishObject.CuisineId = query.Cuisine.Id;

            return dishObject;

        }


        #endregion


        #region Cuisine metods

        public IEnumerable<Cuisine> GetAllCuisines()
        {
            return _context.Cuisines;
        }

       





        #endregion

        #region TypeOfDish metods



        #endregion

    }
}
