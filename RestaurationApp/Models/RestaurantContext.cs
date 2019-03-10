using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurationApp.Models
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options)
            : base(options)
        { }


        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Cuisine> Cuisines { get; set; }
        public DbSet<TypeOfDish> TypesOfDishes { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<RestaurantTable> RestaurantTables { get; set; }
        public DbSet<Person> People { get; set; }
    }
}
