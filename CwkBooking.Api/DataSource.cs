using CwkBooking.Domain.Models;
using System.Collections.Generic;

namespace CwkBooking.Api
{
    public class DataSource
    {
        public DataSource()
        {
            Hotels = GetHotels();
        }

        public List<Hotel> Hotels { get; set; }

        private List<Hotel> GetHotels()
        {
            return new List<Hotel>
            {
                new Hotel
                {
                    HotelId = 1,
                    Name = "Conquest",
                    Stars = 3,
                    Address = "420 Booger St.",
                },

                new Hotel
                {
                    HotelId = 2,
                    Name = "Bonkquest",
                    Stars = 5,
                    Address = "69 Bonk St.",
                }
            };
        }
    }
}
