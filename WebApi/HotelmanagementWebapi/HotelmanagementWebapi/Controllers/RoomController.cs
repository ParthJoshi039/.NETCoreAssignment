using Hotelmanagement.BAL.Interface;
using Hotelmanagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace HotelmanagementWebapi.Controllers
{
    public class RoomController : ApiController
    {
        IRoom room;
        public RoomController(IRoom iroom)
        {
            room = iroom;
        }
        [HttpGet]
        public IHttpActionResult GetRooms(string city, string pincode, int price, string category)
        {
            try
            {
                var result = room.GetRooms(city, pincode, price, category);
                return Ok(result);
            }
            catch
            {
                return InternalServerError();
            }
        }
        [HttpGet]
        public IHttpActionResult CheckRoomAvailability(int roomid, DateTime date)
        {
            var result = room.CheckRoomAvailability(roomid, date);
            return Ok(result);
        }
        [HttpPost]
        public IHttpActionResult AddRoom([FromBody] RoomModel model)
        {
            room.AddRoom(model);
            return Ok("Added Successfully");
        }
        [HttpPost]
        public IHttpActionResult BookRoom([FromBody]BookingModel model)
        {
            room.BookRoom(model);
            return Ok("Booked Successfully");
        }
        [HttpPut]
        public IHttpActionResult UpdateBookingDate([FromUri] int bookigid, [FromBody] BookingModel model)
        {
            room.UpdateBookingDate(bookigid,model);
            return Ok("Updated Successfully");
        }
        [HttpPut]
        public IHttpActionResult UpdateBookingStatus([FromUri] int bookigid, [FromBody] BookingModel model)
        {
            room.UpdateBookingStatus(bookigid, model);
            return Ok("Updated Successfully");
        }
        [HttpDelete]
        public IHttpActionResult DeletBooking(int bookigid)
        {
            room.DeletBooking(bookigid);
            return Ok("Deleted Successfully");

        }
    }
}