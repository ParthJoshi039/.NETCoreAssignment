using Hotelmanagement.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelmanagement.BAL.Interface
{
    public interface IHotel
    {
         List<HotelModel> GetHotels();

        void AddHotel(HotelModel model);
            
    }
}
