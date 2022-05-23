using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApiService.Models;
using HotelApiService.Repository;

namespace HotelApiService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        public IActionResult Get()
        {
            List<Hotel> hotels = HotelRepository.GetHotels();


            return Ok(hotels);
           
        }
    }
}
