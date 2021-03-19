using Hotelmanagement.DAL.Database;
using Hotelmanagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelmanagement.DAL.Repository
{
    public class RoomRepository : IRoomRepository
    {
        List<RoomModel> GetRooms(string city, string pincode, int price, string category)
        {
            using (var entity = new HotelManagementEntities() )
            {
                var result = entity.Rooms.Select(x => new RoomModel()
                {
                  Id=x.Id,
                  HotelId=x.HotelId,
                  RoomName = x.RoomName,
                  Category=x.Category,
                  Price=x.Price,
                  IsActive=x.IsActive,
                  CreatedDate=x.CreatedDate,
                  CreatedBy=x.CreatedBy,
                  UpdatedDate=x.UpdatedDate,
                  UpdatedBy=x.UpdatedBy
                }).ToList();
                return result;
            }
        }
        bool CheckRoomAvailability(int roomid, DateTime date)
        { }
        void AddRoom(RoomModel model)
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
            }
        }
        void BookRoom(BookingModel model)
        { }
        void UpdateBookingDate(int bookigid, BookingModel model)
        { }
        void UpdateBookingStatus(int bookigid, BookingModel model)
        {}
        void DeletBooking(int bookigid)
        { }
    }
}
