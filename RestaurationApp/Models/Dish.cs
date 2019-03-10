using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurationApp.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string DishName { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string ImgUrl { get; set; }

        public virtual Cuisine Cuisine { get; set; }
        public virtual TypeOfDish TypeOfDish { get; set; }
    }
}
