    using Hotelmanagement.BAL.Interface;
    using Hotelmanagement.DAL;
    using Hotelmanagement.DAL.Repository;
    using Hotelmanagement.Model;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Hotelmanagement.BAL
    {
        public class Hotel : IHotel
        {
        private readonly IHotelRepository hotelRepository;
        public Hotel()
        {

        }
        public Hotel(IHotelRepository ihotelRepository)
        {
            hotelRepository = ihotelRepository;
        }
            public void AddHotel(HotelModel model)
            {
                hotelRepository.AddHotel(model);
            }

            public List<HotelModel> GetHotels()
            {
                var result = hotelRepository.GetHotels();
                return result;
            }
        }
    }
