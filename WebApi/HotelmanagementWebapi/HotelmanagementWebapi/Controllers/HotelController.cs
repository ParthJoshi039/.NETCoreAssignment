using Hotelmanagement.Model;
using Hotelmanagement.BAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace HotelmanagementWebapi.Controllers
{
    public class HotelController : ApiController
    {
        IHotel hotel;
        public HotelController()
        {

        }
        public HotelController(IHotel ihotel)
        {
            hotel = ihotel;
        }
        [HttpGet]
        [Route("Hotel/GetHotels")]
        public IHttpActionResult GetHotels()
        {
            try
            {
                var result = hotel.GetHotels();
                return Ok(result);
            }
            catch(Exception e)
            {
                return Ok();
            }
        }
        [HttpPost]
        [Route("Hotel/AddHotel")]
        public IHttpActionResult AddHotel([FromBody] HotelModel model)
        {
            hotel.AddHotel(model);
            return Ok("Added Successfully");
        }

    }
}