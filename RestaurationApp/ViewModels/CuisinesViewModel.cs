using RestaurationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurationApp.ViewModels
{
    public class CuisinesViewModel
    {
        public IEnumerable<Cuisine> cuisines { get; set; }
    }
}
