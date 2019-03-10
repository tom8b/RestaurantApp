using RestaurationApp.Models;
using RestaurationApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurationApp.Services.Implemented
{
    public class PersonService : IPersonService
    {
        private RestaurantContext _context;

        public PersonService(RestaurantContext context)
        {
            _context = context;
        }

        public IEnumerable<Person> GetAllPeople()
        {
            return _context.People;
        }
    }
}
