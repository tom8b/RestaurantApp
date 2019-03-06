using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurationApp.Models
{
    public class TypeOfDish
    {
        public int Id { get; set; }
        /// <summary>
        /// Nazwa typu dania, np. zupa, drugie danie
        /// </summary>
        public string Name { get; set; }
        
    }
}
