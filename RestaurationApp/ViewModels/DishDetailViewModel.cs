using RestaurationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurationApp.ViewModels
{
    public class DishDetailViewModel
    {
        public string dishName { get; set; }
        public string dishDescribtion  { get; set; }
        public decimal cost { get; set; }
        public string cuisineName { get; set; }
        public string typeOfDish { get; set; }
        public int CuisineId { get; set; }
    }
}
