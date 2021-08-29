using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoT.Smart.Parking.Repository
{
    public class ParkingMeter
    {
        /// <summary>
        /// last updated time of parking meter location
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// is parking location available
        /// </summary>
        public bool isAvailable{ get; set; }

        /// <summary>
        /// Id of parking meter
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Id of parking area
        /// </summary>
        public int AreaId { get; set; }
    }
}
