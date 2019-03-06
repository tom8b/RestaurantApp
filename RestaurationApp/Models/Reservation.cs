using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurationApp.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        /// <summary>
        /// na ile gości potrzebny jest stolik
        /// </summary>
        public int NumberOfGuests { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string TelephoneNumber { get; set; }
        public string MailAddress { get; set; }

        /// <summary>
        /// Na kiedy stolik jest zabukowany
        /// </summary>
        public DateTime ReservationDate { get; set; }

        public virtual IEnumerable<RestaurantTable> Tables { get; set; }
    }
}
