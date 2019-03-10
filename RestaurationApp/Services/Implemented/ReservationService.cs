using RestaurationApp.Models;
using RestaurationApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurationApp.Services.Implemented
{
    public class ReservationService : IReservationService
    {
        private RestaurantContext _context;

        public ReservationService(RestaurantContext context)
        {
            _context = context;
        }

        public void AddReservation(Reservation reservation)
        {
            _context.Add(reservation);
        }
    }
}
