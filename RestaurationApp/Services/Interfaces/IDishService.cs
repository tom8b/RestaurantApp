using RestaurationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurationApp.Services.Interfaces
{

    public interface IDishService
    {
        IEnumerable<Dish> GetAll();
        Dish GetDishById(int id);

    }
}
