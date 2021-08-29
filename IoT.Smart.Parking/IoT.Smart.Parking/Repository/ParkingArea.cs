using Geolocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoT.Smart.Parking.Repository
{
    /// <summary>
    /// An object for parking area
    /// </summary>
    public class ParkingArea
    {
        /// <summary>
        /// ID of a parking area
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// No of slots available in parking area
        /// </summary>
        public int AvailableSlots { get; set; }
        
        /// <summary>
        /// Address of parking area
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// geo-location of a parking area
        /// </summary>
        public Coordinate Location { get; set; }

        /// <summary>
        /// distance from your point
        /// </summary>
        public double Distance { get; set; }
    }
}
