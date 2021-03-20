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
    public class HotelRepository : IHotelRepository
    {
        public void AddHotel(HotelModel model)
        {
            using (var entity = new HotelManagementEntities())
            {
                var hotel = new DAL.Database.Hotel();
                hotel.HotelName = model.HotelName;
                hotel.Address = model.Address;
                hotel.City = model.City;
                hotel.PinCode = model.PinCode;
                hotel.ContactNo = model.ContactNo;
                hotel.ContactPerson = model.ContactPerson;
                hotel.WebSite = model.WebSite;
                hotel.Facebook = model.Facebook;
                hotel.Twitter = model.Twitter;
                hotel.IsActive = model.IsActive;
                hotel.CreatedBy = model.CreatedBy;
                hotel.CreatedDate = model.CreatedDate;
                hotel.UpdatedBy = model.UpdatedBy;
                hotel.UpdatedDate = model.UpdatedDate;//orderby
                entity.Hotels.Add(hotel);
                entity.SaveChanges();
            }
        }
        public List<HotelModel> GetHotels()
        {
            using (var entity = new HotelManagementEntities())
            {
                var result = entity.Hotels.Select(x => new HotelModel()
                {
                    Id = x.Id,
                    HotelName = x.HotelName,
                    Address = x.Address,
                    City = x.City,
                    PinCode = x.PinCode,
                    ContactNo = x.ContactNo,
                    ContactPerson = x.ContactPerson,
                    WebSite = x.WebSite,
                    Facebook = x.Facebook,
                    Twitter = x.Twitter,
                    IsActive = x.IsActive,
                    CreatedBy = x.CreatedBy,
                    CreatedDate = x.CreatedDate,
                    UpdatedBy = x.UpdatedBy,
                    UpdatedDate = x.UpdatedDate//orderby
                }).ToList();
                return result;
            }

        }
    }
}
