using Hotelmanagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelmanagement.DAL.Repository
{
    public interface IRoomRepository
    {
        List<RoomModel> GetRooms(string city, string pincode, int price, string category);
        bool CheckRoomAvailability(int roomid, DateTime date);
        void AddRoom(RoomModel model);
        void BookRoom(BookingModel model);
        void UpdateBookingDate(int bookigid, BookingModel model);
        void UpdateBookingStatus(int bookigid, BookingModel model);
        void DeletBooking(int bookigid);
    }
}
