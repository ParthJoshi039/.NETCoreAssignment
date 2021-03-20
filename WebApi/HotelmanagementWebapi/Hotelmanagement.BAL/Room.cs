using Hotelmanagement.BAL.Interface;
using Hotelmanagement.DAL.Repository;
using Hotelmanagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelmanagement.BAL
{
    public class Room : IRoom 
    {
        private readonly IRoomRepository roomRepository;
        public Room()
        {

        }
        public Room(IRoomRepository iroomRepository)
        {
            roomRepository = iroomRepository;
        }
        public void AddRoom(RoomModel model)
        {
            roomRepository.AddRoom(model);
        }

        public void BookRoom(BookingModel model)
        {
            roomRepository.BookRoom(model);
        }

        public bool CheckRoomAvailability(int roomid, DateTime date)
        {
            return roomRepository.CheckRoomAvailability(roomid, date);
        }

        public void DeletBooking(int bookigid)
        {
            roomRepository.DeletBooking(bookigid);
        }

        public List<RoomModel> GetRooms(string city, string pincode, int price, string category)
        {
            var result = roomRepository.GetRooms(city,pincode,price,category);
            return result;
        }

        public void UpdateBookingDate(int bookigid, BookingModel model)
        {
            roomRepository.UpdateBookingDate(bookigid,model);
        }

        public void UpdateBookingStatus(int bookigid, BookingModel model)
        {
            roomRepository.UpdateBookingStatus(bookigid, model);
        }
    }
}
