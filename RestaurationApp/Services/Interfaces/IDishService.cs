using RestaurationApp.Models;
using RestaurationApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurationApp.Services.Interfaces
{

    public interface IDishService
    {
        #region Dish methods
        IEnumerable<Dish> GetAll();
        IEnumerable<Dish> GetDishesFromCuisine(int CuisineId);
        Dish GetDishById(int id);
        #endregion

        #region Cuisine methods
        IEnumerable<Cuisine> GetAllCuisines();
        #endregion
    }
}
