using Hotelmanagement.BAL.Interface;
using Hotelmanagement.DAL;
using Hotelmanagement.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Unity.Extension;
using Unity.WebApi;
using Unity;

namespace Hotelmanagement.BAL
{
    public class UnityHelper : UnityContainerExtension
    {
        protected override void Initialize()
        {

            //Container.RegisterType<IRoomRepository, RoomRepository>();
            Container.RegisterType<IHotelRepository, HotelRepository>();
            Container.RegisterType<IRoomRepository, RoomRepository>();
            //Container.RegisterType<IHotel, Hotel>();
            //Container.RegisterType<IRoom, Room>();
        }
    }
}
