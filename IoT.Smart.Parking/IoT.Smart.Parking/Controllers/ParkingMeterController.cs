using Geolocation;
using IoT.Smart.Parking.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoT.Smart.Parking.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParkingMeterController : ControllerBase
    {
        private readonly ILogger<ParkingMeterController> _logger;

        public ParkingMeterController(ILogger<ParkingMeterController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Retrieve the state of parking meter
        /// </summary>
        [HttpGet("GetMeterState")]
        public IEnumerable<ParkingMeter> Get([FromQuery]int Id)
        {
            return Enumerable.Range(1, 5).Select(index => new ParkingMeter
            {
                Date = DateTime.Now.AddDays(index),
                Id = new Random().Next(),
                AreaId = new Random().Next(),
                isAvailable = new Random().Equals(null)
            })
            .ToArray();
        }


        /// <summary>
        /// Retrieves closest available parking spot
        /// </summary>
        [HttpPost("GetNearest")]
        public IEnumerable<ParkingArea> GetNearest([FromQuery]Coordinate clientLocation)
        {
            return Enumerable.Range(1, 2).Select(index => new ParkingArea
            {
                Address = string.Empty,
                AvailableSlots = new Random().Next(),
                Id = new Random().Next(),
                Distance = new Random().NextDouble()
            })
            .ToArray();
        }

        /// <summary>
        /// Retreive parking area state data to drive a map of parking spots and their availability for a given region
        /// </summary>
        [HttpGet("GetParkingState")]
        public IEnumerable<ParkingArea> GetParkingState()
        {
            return Enumerable.Range(1, 5).Select(index => new ParkingArea
            {
                Address = string.Empty,
                AvailableSlots = new Random().Next(),
                Id = new Random().Next(),
                Distance = new Random().NextDouble()
            })
            .ToArray();
        }
    }
}
