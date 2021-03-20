using Hotelmanagement.DAL.Database;
using Hotelmanagement.DAL.Repository;
using Hotelmanagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelmanagement.DAL
{
    public class RoomRepository : IRoomRepository
    {
        public List<RoomModel> GetRooms(string city, string pincode, int price, string category)
        {
            using (var entity = new HotelManagementEntities())
            {
                var result = entity.Rooms.Select(x => new RoomModel()
                {
                    Id = x.Id,
                    HotelId = x.HotelId,
                    RoomName = x.RoomName,
                    Category = x.Category,
                    Price = x.Price,
                    IsActive = x.IsActive,
                    CreatedDate = x.CreatedDate,
                    CreatedBy = x.CreatedBy,
                    UpdatedDate = x.UpdatedDate,
                    UpdatedBy = x.UpdatedBy
                }).ToList();
                return result;
            }
        }
        public bool CheckRoomAvailability(int roomid, DateTime date)
        {
            using (var entity = new HotelManagementEntities())
            {
                var qry = (from booking in entity.Bookings where booking.RoomId == roomid && booking.BookingDate == date select booking.Status).FirstOrDefault();
                if (qry == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public void AddRoom(RoomModel model)
        {
            using (var entity = new HotelManagementEntities())
            {
                var room = new DAL.Database.Room();
                room.Id = model.Id;
                room.HotelId = model.HotelId;
                room.RoomName = model.RoomName;
                room.Category = model.Category;
                room.Price = model.Price;
                room.IsActive = model.IsActive;
                room.CreatedDate = model.CreatedDate;
                room.CreatedBy = model.CreatedBy;
                room.UpdatedDate = model.UpdatedDate;
                room.UpdatedBy = model.UpdatedBy;
                entity.Rooms.Add(room);
                entity.SaveChanges();
            }
        }
        public void BookRoom(BookingModel model)
        {
            using (var entity = new HotelManagementEntities())
            {
                Booking booking = new Booking()
                {
                    BookingDate = model.BookingDate,
                    RoomId = model.RoomId,
                    Status = model.Status

                };
                entity.Bookings.Add(booking);
                entity.SaveChanges();
            }
        }
        public void UpdateBookingDate(int bookigid, BookingModel model)
        {
            using (var entity = new HotelManagementEntities())
            {
                var qry = entity.Bookings.Where(x => x.Id == bookigid).FirstOrDefault();
                qry.BookingDate = model.BookingDate;
                entity.SaveChanges();
            }
        }
        public void UpdateBookingStatus(int bookigid, BookingModel model)
        {
            using (var entity = new HotelManagementEntities())
            {
                var qry = entity.Bookings.Where(x => x.Id == bookigid).FirstOrDefault();
                qry.Status = model.Status;
                entity.SaveChanges();
            }
        }
        public void DeletBooking(int bookigid)
        {
            using (var entity = new HotelManagementEntities())
            {
                var qry = entity.Bookings.Where(x => x.Id == bookigid).FirstOrDefault();
                qry.Status = "Deleted";
                entity.SaveChanges();
            }
        }
    }
}
